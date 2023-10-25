using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomUserControls
{
    public partial class SWCodi: UserControl
    {
        public SWCodi()
        {
            InitializeComponent();
        }

        public bool Requerit { get; set; } = true;

        public enum TipusNivell
        {
            GS,
            GM
        }

        private TipusNivell _Nivell;

        public TipusNivell Nivell
        {
            get { return _Nivell; }
            set { _Nivell = value; }
        }

        private void CodiTxt_Leave(object sender, EventArgs e)
        {
            string codi = CodiTxt.Text;
            ValidaCodi(codi);
        }

        private void ValidaCodi(string codi)
        {
            string desc = "";
            if (Nivell == TipusNivell.GS && codi == "S2AM")
            {
                desc = "Desenvolupament aplicacions multiplataforma";
            }
            else if (Nivell == TipusNivell.GS && codi == "S2SX")
            {
                desc = "Administració de sistemes Informàtics en xarxa";
            }
            else if (Nivell == TipusNivell.GM && codi == "M2SX")
            {
                desc = "Sistemes MicroInformàtics i Xarxes";
            }

            DescTxt.Text = desc;
        }

    }
}
