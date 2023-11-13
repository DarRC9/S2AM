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

namespace ADOPractica
{
    public partial class ADOform : Form
    {
        public ADOform()
        {
            InitializeComponent();
        }

        #region Global Variables

        private SqlConnection conn;
        private string query;
        DataSet dts;
        bool newData = false;
        bool cellClicked = false;
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

            adapter.Fill(dts, "Species");

            dtgSpecies.DataSource = dts.Tables[0];

            conn.Close();

            dtgSpecies.Columns[0].Visible = false;
            dtgSpecies.Columns[1].HeaderText = "Species Code";
            dtgSpecies.Columns[2].HeaderText = "Species Description";
        }

        private void Actualitzar()
        {
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

        private void ADOform_Load(object sender, EventArgs e)
        {
            PortarDades();
        }

        private void DataSetBtn_Click(object sender, EventArgs e)
        {
            string XMLDataset = dts.GetXml();
            XMLTxt.Text = XMLDataset;
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
