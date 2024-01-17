using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_EF
{
    public partial class frmCRUDEF : Form
    {
        public frmCRUDEF()
        {
            InitializeComponent();
        }

        UserRanksEntities db = new UserRanksEntities();
        List<UserRank> userRank;
        bool newRow = false;

        private bool AnyTextFieldIsBlank()
        {
            return string.IsNullOrWhiteSpace(CodeRankTxt.Text) ||
                   string.IsNullOrWhiteSpace(DescRankTxt.Text);
        }

        private void LoadData()
        {
            userRank = db.UserRanks.ToList();

            TableDgv.DataSource = userRank;
            CreateBindings();
        }

        private void frmCRUDEF_Load(object sender, EventArgs e)
        {
            LoadData();
            CustomizedDataGridView();
        }
            
        private void CreateBindings()
        {
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                textBox.DataBindings.Clear();
                textBox.DataBindings.Add("Text", userRank, textBox.Tag.ToString());
                textBox.Validated += OnTextBoxValidation;
            }
            //CodeRankTxt.Clear();
            //CodeRankTxt.DataBindings.Add("Text", userRank, CodeRankTxt.Tag.ToString());

            //DescRankTxt.Clear();
            //DescRankTxt.DataBindings.Add("Text", userRank, DescRankTxt.Tag.ToString());
        }


        private void OnTextBoxValidation(object sender, EventArgs e)
        {
            ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }

        private void ClearBindings()
        {

            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.DataBindings.Clear();
                    textBox.Clear();
                    textBox.Validated -= OnTextBoxValidation;
                }
            }
            //CodeRankTxt.Focus();
            //CodeRankTxt.Clear();
            //CodeRankTxt.Text = "";

            //DescRankTxt.Clear();
            //DescRankTxt.Text = "";
        }

        private void CustomizedDataGridView()
        {
            TableDgv.Columns["idUserRank"].Visible = false;
            TableDgv.Columns["CodeRank"].HeaderText = "Rank Code";
            TableDgv.Columns["DescRank"].HeaderText = "Rank Description";
        }


        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (newRow)
            {
                UserRank userRank = new UserRank
                {
                    CodeRank = CodeRankTxt.Text,
                    DescRank = DescRankTxt.Text
                };
                try
                {
                    if (AnyTextFieldIsBlank())
                    {
                        throw new Exception("Can't leave any text field blank.");
                    }
                    db.UserRanks.Add(userRank);

                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                newRow = false;
            }
            db.SaveChanges();
            LoadData();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            newRow = true;
            ClearBindings();
        }
    }
}
