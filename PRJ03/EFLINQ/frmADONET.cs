using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EFLINQ
{
    public partial class frmADONET : Form
    {
        public frmADONET()
        {
            InitializeComponent();
        }

        ClientsEntities db = new ClientsEntities();
        List<NewContact> newCon;
        List<ContactSystem> conSys;

        public NewContact _currentContact;
        
        private void frmADONET_Load(object sender, EventArgs e)
        {
            //LoadData();
        } 

        private void LoadData()
        {
            conSys = (from c in db.ContactSystem select c).ToList();
            newCon = db.NewContact.ToList();

            TableDgv.DataSource = conSys;
        }

        private void openEdiFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "EDI Files|*.edi|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ProcessEdiFile(filePath);
            }
        }

        private void ProcessEdiFile(string filePath)
        {
            List<string> ediLines = File.ReadAllLines(filePath).ToList();

            ediLines.ForEach(ProcessEdiLine);
        }

        private void ProcessEdiLine(string line)
        {
            string[] values = line.Split('|');
            string recordType = values[0];

            if (recordType == "CON") { 

                string name = values[1];
                string dob = values[2];
                string phone = values[3];

                NewContact newContact = new NewContact
                {
                    Name = name,
                    BirthDate = dob,

                };

                db.NewContact.Add(newContact);
                db.SaveChanges();

                NewContact currentContact = db.NewContact.FirstOrDefault(c => c.Name == name && c.BirthDate == dob);
                _currentContact = currentContact;

                ContactSystem contactSystem = new ContactSystem
                {
                    IdContact = _currentContact.idContact,
                    Description = "Mobile",
                    SystemValue = phone,
                };

                db.ContactSystem.Add(contactSystem);
                db.SaveChanges();

        } else if (recordType == "SYS")
            {
                string desc = values[1];
                string value = values[2];

                ContactSystem contactSystem = new ContactSystem
                {
                    IdContact = _currentContact.idContact,
                    Description = desc,
                    SystemValue = value,
                };

                db.ContactSystem.Add(contactSystem);
                db.SaveChanges();
            }
        }

        private void OpenEDIBtn_Click(object sender, EventArgs e)
        {
            openEdiFile();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
