using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormToTest
{
    public partial class TestForm : ADOPractica.frmLoadTable
    {
        public TestForm()
        {
            InitializeComponent();
            InitializeComponent();
            SetConnectionString("Server=localhost;Database=SecureCore;Trusted_Connection=True;");
            SetTableName("Species");
            SetQuery("select * from species");
        }

        protected override void CustomizeDataGridView()
        {
            base.CustomizeDataGridView();
            MyTable.Columns["idFiliation"].Visible = false;
            MyTable.Columns["CodeFiliation"].HeaderText = "Code";
            MyTable.Columns["DescFiliations"].HeaderText = "Description";
        }
    }
}
