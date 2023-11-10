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
    public abstract partial class frmLoadTable : Form
    {
        public frmLoadTable()
        {
            InitializeComponent();
        }

        #region Global Variables

        private SqlConnection _sqlConnection;
        private string _query;
        private DataSet _dataSet;
        private bool _isNew;
        private string _tableToLoad;
        private string _connectionString;
        #endregion

        #region Methods

        public void SetTableName(string tableName)
        {
            _tableToLoad = tableName;
        }
        public void SetQuery(string query)
        {
            _query = query;
        }
        public void SetConnectionString(string connectionString)
        {
            _connectionString = connectionString;
        }
        private void SetConnection()
        {
            _sqlConnection = new SqlConnection(_connectionString);
        }
        private void FetchData()
        {
            SetConnection();
            _dataSet = new DataSet();
            using (SqlDataAdapter adapter = new SqlDataAdapter(_query, _sqlConnection))
            {
                _sqlConnection.Open();
                adapter.Fill(_dataSet, _tableToLoad);
                dgvTable.DataSource = _dataSet.Tables[0];
                _sqlConnection.Close();
            }
            BindTextBoxesToData();
            CustomizeDataGridView();
        }


        private void BindTextBoxesToData()
        {
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                textBox.DataBindings.Clear();
                textBox.DataBindings.Add("Text", _dataSet.Tables[0], textBox.Tag.ToString());
                textBox.Validated += OnTextBoxValidate;
            }
        }
        private void OnTextBoxValidate(object sender, EventArgs e)
        {
            ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }
        private void UpdateTable()
        {
            _sqlConnection.Open();
            if (_isNew)
            {
                InsertNewRowFromTextBoxes();
            }
            using (SqlDataAdapter adapter = new SqlDataAdapter(_query, _sqlConnection))
            {
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                if (_dataSet.HasChanges())
                {
                    int modifiedRecords = adapter.Update(_dataSet.Tables[0]);
                    MessageBox.Show($"Modified records: {modifiedRecords}");
                }
            }
            FetchData();
            _sqlConnection.Close();
            _isNew = false;
        }
        private void InsertNewRowFromTextBoxes()
        {
            DataRow dataRow = _dataSet.Tables[0].NewRow();
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                dataRow[textBox.Tag.ToString()] = textBox.Text;
            }
            Form parentForm = this.FindForm();
            foreach (Control control in parentForm.Controls)
            {
                if (control is TextBox textBox)
                {
                    dataRow[textBox.Tag.ToString()] = textBox.Text;
                }
            }
            _dataSet.Tables[0].Rows.Add(dataRow);
        }
        private void ClearTextBoxes()
        {
            _isNew = true;
            Form parentForm = this.FindForm();
            foreach (Control control in parentForm.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.DataBindings.Clear();
                    textBox.Clear();
                    textBox.Validated -= OnTextBoxValidate;
                }
            }
        }
        protected virtual void CustomizeDataGridView()
        {
        }
        protected DataGridView MyTable
        {
            get { return dgvTable; }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
        private void btnImportData_Click(object sender, EventArgs e)
        {
            FetchData();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        /*-------------------------------*/

        #endregion
 

    }
}

