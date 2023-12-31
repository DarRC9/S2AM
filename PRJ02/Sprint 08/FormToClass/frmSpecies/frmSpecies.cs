﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmSpecies
{
    public partial class frmSpecies : ADOPractica.ADOformClass
    {
        public frmSpecies()
        {
            InitializeComponent();
            setDbParameters(
                "Server=localhost;Database=SecureCore;Trusted_Connection=True;",
                "Species",
                "Select * from Species");
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
