using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public partial class AppLauncher : UserControl
    {
        public AppLauncher()
        {
            InitializeComponent();
        }


        public enum TipusDada
        {
            Numero,
            Text,
            Codi
        }

        private TipusDada _DadaPermesa;

        public TipusDada DadaPermesa
        {
            get { return _DadaPermesa; }
            set
            {
                _DadaPermesa = value;
            }
        }
    }
}
