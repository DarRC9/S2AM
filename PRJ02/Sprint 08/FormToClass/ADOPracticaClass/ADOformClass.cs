using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADOPractica
{
    public partial class ADOformClass : Form
    {
        #region Variables
        private SqlConnection _connection;
        private string _query;
        private DataSet _dataSet;
        private bool _newData;
        private string _dbTable;
        private string _connectionString;
        #endregion

        public ADOformClass()
        {
            InitializeComponent();
        }

        #region Methods

        public void setDbParameters(string connectionString, string dbTable, string query)
        {
            _connectionString = connectionString;
            _dbTable = dbTable;
            _query = query;
        }
        
        private void CreateConnection()
        {
            _connection = new SqlConnection(_connectionString);
        }
        private void FetchData()
        {
            CreateConnection();
            _dataSet = new DataSet();

            using (SqlDataAdapter adapter = new SqlDataAdapter(_query, _connection))
            {
                _connection.Open();
                adapter.Fill(_dataSet, _dbTable);
                dgvTable.DataSource = _dataSet.Tables[0];
                _connection.Close();
            }

            CustomizeDataGridView();
            BindDataAndTextBoxes();
        }

        private void BindDataAndTextBoxes()
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
            _connection.Open();

            if (_newData)
            {
                CreateNewRow();
            }

            using (SqlDataAdapter adapter = new SqlDataAdapter(_query, _connection))
            {
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);

                if (_dataSet.HasChanges())
                {
                    int modifiedRecords = adapter.Update(_dataSet.Tables[0]);
                    MessageBox.Show(modifiedRecords + "recods modified" );
                }
            }

            FetchData();
            _connection.Close();
            _newData = false;
        }
        private void CreateNewRow()
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
        private void ClearAllBoxes()
        {
            _newData = true;
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
        

        protected DataGridView MyTable
        {
            get { return dgvTable; }
        }

        protected virtual void CustomizeDataGridView()
        {
        }

        #endregion

        #region Events
        private void AddBtn_Click(object sender, EventArgs e)
        {
            ClearAllBoxes();
        }
        private void FetchBtn_Click(object sender, EventArgs e)
        {
            FetchData();
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
        #endregion
    }
}
