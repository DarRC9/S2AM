using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FormBaseClassLibrary
{
    public abstract class DataSetClass
    {

        #region Global Variables

        private SqlConnection conn;
        private string query;
        DataSet dts;
        bool newData = false;
        bool cellClicked = false;

        private string _DescTextbox;

        public string DescTexbox
        {
            get { return _DescTextbox; }
            set{ _DescTextbox = value;
            }
        }

        private string _CodeTextbox;

        public string CodeTexbox
        {
            get { return _CodeTextbox; }
            set
            {
                _CodeTextbox = value;
            }
        }

        private string _DataGridViewName;

        public string DataGridViewName
        {
            get { return _DataGridViewName; }
            set
            {
                _DataGridViewName= value;
            }
        }

        private Form parentForm = Application.OpenForms.Cast<Form>().FirstOrDefault();

        #endregion

        #region Methods

        public TextBox FindTextBox(string textBoxName)
        {
            return parentForm.Controls.OfType<TextBox>().FirstOrDefault(c => c.Name == textBoxName);
        }

        public DataGridView FindDataGridView(string dataGridViewName)
        {
            return parentForm.Controls.OfType<DataGridView>().FirstOrDefault(c => c.Name == dataGridViewName);
        }

        private void ConfigurarConnexio(string cnx)
        {
            //string cnx;
            //cnx = "Server=localhost;Database=SecureCore;Trusted_Connection=True;";
            conn = new SqlConnection(cnx);
        }

        private void PortarDades(string query, string cnx, bool idVisible)
        {
            ConfigurarConnexio(cnx);
            SqlDataAdapter adapter;
            dts = new DataSet();
            DataGridView dtg = FindDataGridView(DataGridViewName);
            
            //query = "select * from species";
            adapter = new SqlDataAdapter(query, conn);
            conn.Open();

            adapter.Fill(dts, "Species");

            dtg.DataSource = dts.Tables[0];

            conn.Close();

            dtg.Columns[0].Visible = idVisible;
        }

        private void Actualitzar()
        {
            TextBox CodeTxt = FindTextBox(CodeTexbox);
            TextBox DescTxt = FindTextBox(DescTexbox);
            if (newData)
            {
                DataRow newRow = dts.Tables["Species"].NewRow();
                newRow["CodeSpecie"] = CodeTxt.Text;
                newRow["DescSpecie"] = DescTxt.Text;
                dts.Tables["Species"].Rows.Add(newRow);
                newData = false;
            }

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

        private void GetDataSet(RichTextBox xmlTxt, DataSet dts)
        {
            string XMLDataset = dts.GetXml();
            xmlTxt.Text = XMLDataset;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Actualitzar();
        }

        private void dtgSpecies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string codeSpecie = "";
            string descSpecie = "";
            cellClicked = true;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgSpecies.Rows[e.RowIndex];

                codeSpecie = selectedRow.Cells[1].Value.ToString();
                descSpecie = selectedRow.Cells[2].Value.ToString();
            }

            CodeTxt.Text = codeSpecie;
            DescTxt.Text = descSpecie;
        }

        public bool dtgCellClicked(Array allTxt, DataGridView dtg, DataGridViewCellEventArgs e)
        {
            string codeSpecie = "";
            string descSpecie = "";
            cellClicked = true;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dtg.Rows[e.RowIndex];

                int columnNumber = 0;
                foreach (TextBox txt in allTxt)
                {
                    columnNumber++;
                    txt.Text = selectedRow.Cells[columnNumber].Value.ToString();    
                }

                codeSpecie = selectedRow.Cells[1].Value.ToString();
                descSpecie = selectedRow.Cells[2].Value.ToString();
            }

            CodeTxt.Text = codeSpecie;
            DescTxt.Text = descSpecie;

            return cellClicked;
        }

        private void CodeTxt_TextChanged(object sender, EventArgs e)
        {
            if (newData == false && cellClicked)
            {
                DataGridViewRow selectedRow = dtgSpecies.Rows[dtgSpecies.CurrentCell.RowIndex];
                selectedRow.Cells[1].Value = CodeTxt.Text;
            }
        }

        private void DescTxt_TextChanged(object sender, EventArgs e)
        {
            if (newData == false && cellClicked)
            {
                DataGridViewRow selectedRow = dtgSpecies.Rows[dtgSpecies.CurrentCell.RowIndex];
                selectedRow.Cells[2].Value = DescTxt.Text;
            }
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            newData = true;
            dtgSpecies.ClearSelection();
            CodeTxt.Text = "";
            DescTxt.Text = "";
        }

        #endregion
    }
}
