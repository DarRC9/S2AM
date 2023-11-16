using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DataAccesComponent;

namespace DataAccesBase
{
    public partial class frmDataAccesBase : Form
    {
        #region Variables
        private readonly DataConnection dbConnection;
        private DataSet _dataSet;
        private bool _newData;
        private string _dbTable;
        private string _query;
        #endregion

        public frmDataAccesBase()
        {
            InitializeComponent();
            dbConnection = new DataConnection();
        }

        #region Methods
        public void SetDbParameters(string dbTable, string query)
        {
            _dbTable = dbTable;
            _query = query;
        }

        private void FetchData()
        {
            _dataSet = new DataSet();
            _dataSet = dbConnection.GetTable(_dbTable);
            TableDgv.DataSource = _dataSet.Tables[0];

            BindDataAndTextBoxes();
            CustomizeDataGridView();
        }

        private void BindDataAndTextBoxes()
        {
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                textBox.DataBindings.Clear();
                textBox.DataBindings.Add("Text", _dataSet.Tables[0], textBox.Tag.ToString());
                textBox.Validated += OnTextBoxValidation;
            }
        }

        private void OnTextBoxValidation(object sender, EventArgs e)
        {
            ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }

        private void UpdateTable()
        {
            if (_newData)
            {
                InsertNewRowFromTextBoxes();
            }
            dbConnection.UpdateData(_query, _dataSet);
            FetchData();
            _newData = false;
        }
        private void InsertNewRowFromTextBoxes()
        {
            DataRow dataRow = _dataSet.Tables[0].NewRow();
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                dataRow[textBox.Tag.ToString()] = textBox.Text;
            }
            _dataSet.Tables[0].Rows.Add(dataRow);
        }
        private void ClearAllBoxes()
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
        }
        protected virtual void CustomizeDataGridView()
        {
        }
        protected DataGridView MyTable
        {
            get { return TableDgv; }
        }
        #endregion

        #region Events

        private void AddBtn_Click(object sender, EventArgs e)
        {
            _newData = true;
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
