using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PracticaADO
{
    public partial class frmADO : Form
    {
        public frmADO()
        {
            InitializeComponent();
        }


        #region Global Variables

        private SqlConnection conn;
        private string query;
        DataSet dts;

        #endregion

        #region Methods

        private void ConfigurarConnexio()
        {
            string cnx;
            cnx = "Server=localhost;Database=SecureCore;Trusted_Connection=True;";
            conn = new SqlConnection(cnx);

        }

        private void PortarDades()
        {
            ConfigurarConnexio();
            SqlDataAdapter adapter;
            dts = new DataSet();

            query = "select * from species";
            adapter = new SqlDataAdapter(query, conn);
            conn.Open();

            adapter.Fill(dts, "MyTable");

            dtgSpecies.DataSource = dts.Tables["MyTable"];

            conn.Close();
        }

        private void Actualitzar()
        {
            conn.Open();

            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(adapter);

            if (dts.HasChanges())
            {
                int result = adapter.Update(dts.Tables[0]);
                MessageBox.Show("Registres modificats: " + result.ToString());
            }
            conn.Close();
        }

        #endregion

        #region Events

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'secure_CoreDataSet.Species' table. You can move, or remove it, as needed.
            //this.speciesTableAdapter.Fill(this.secure_CoreDataSet.Species);

            PortarDades();
        }


        #endregion

        private void DataSetBtn_Click(object sender, EventArgs e)
        {
            string XMLDataset = dts.GetXml();
            XMLTxt.Text = XMLDataset;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Actualitzar();
        }


    }
}
