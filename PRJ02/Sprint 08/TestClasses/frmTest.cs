using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestClasses
{
    public partial class frmTest : ADOPractica.frmLoadTable
    {
        public frmTest()
        {
            InitializeComponent();
            SetConnectionString("Server=localhost;Database=SecureCore;Trusted_Connection=True;");
            SetTableName("Species");
            SetQuery("select * from species");
        }
        protected override void CustomizeDataGridView()
        {
            base.CustomizeDataGridView();
            MyTable.Columns["idSpecie"].Visible = false;
            MyTable.Columns["CodeSpecie"].HeaderText = "Code";
            MyTable.Columns["DescSpecie"].HeaderText = "Description";
        }
    }
}
