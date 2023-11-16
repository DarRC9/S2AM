using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeciesManagement
{
    public partial class SpeciesForm : DataAccesBase.frmDataAccesBase
    {
        public SpeciesForm()
        {
                InitializeComponent();
                SetDbParameters("Species", "Select * from Species");
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
