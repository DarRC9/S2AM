using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;


namespace InheritedControls
{
    public class SWTextbox : TextBox
    {
        public SWTextbox()
        {
            InitializeComponent();
        }

        private string TextInput;

        public bool CampBuit { get; set; } = true;
        public bool ClauForanea { get; set; } = false;

        private string _Placeholder = "Placeholder";

        public string Placeholder
        {
            get { return _Placeholder; }
            set { _Placeholder = value; }
        }

        public string ControlComplementariTxt;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.Text = Placeholder;
            this.ForeColor = Color.Gray;
            this.BackColor = Color.LightGray;
            // 
            // SWTextbox
            // 
            this.Enter += new System.EventHandler(this.SWTextbox_Enter);
            this.Leave += new System.EventHandler(this.SWTextbox_Leave);
            this.ResumeLayout(false);

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

        public string ControlComplementari
        {
            get { return ControlComplementariTxt; }
            set { ControlComplementariTxt = value; }
        }

        private void SWTextbox_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

            string input = this.Text;
            Regex rgx_txt = new Regex(@"^[a-zA-Z]+$");
            Regex rgx_num = new Regex(@"^-?\d+(\.\d+)?$");
            Regex rgx_cod = new Regex(@"^[A-Z]{4}\\-\\d{3}\\/[13579][AEIOU]$");

            bool verificat = false;

            if (!CampBuit && string.IsNullOrWhiteSpace(input))
            {
                this.Focus();
                return;
            } else if (input == "")
            {
                this.Text = this.Placeholder;
                this.BackColor = Color.White;
                this.ForeColor = Color.Gray;
                this.BackColor = Color.LightGray;
                return;
            } else if (!string.IsNullOrWhiteSpace(input) && this.DadaPermesa == TipusDada.Numero) 
            {
                if (rgx_num.IsMatch(input))
                {
                    verificat = true; 
                } else
                {
                    verificat = false;
                }

            } else if(!string.IsNullOrWhiteSpace(input) && this.DadaPermesa == TipusDada.Text)
            {
                if (rgx_txt.IsMatch(input))
                {
                    verificat = true;
                } else
                {
                    verificat = false;
                }
            } else if (!string.IsNullOrWhiteSpace(input) && this.DadaPermesa == TipusDada.Codi)
            {
                Console.WriteLine(input);
                Console.WriteLine(rgx_cod);
                if (rgx_cod.IsMatch(input))
                {
                    verificat = true;
                } else
                {
                    verificat = false;
                }
            }
                
            if (!verificat)
            {
                this.Focus();
            } else
            {
                this.TextInput = this.Text;
            }
            this.BackColor = Color.White;

            Form frm = this.FindForm();

            foreach (Control ctr in frm.Controls)
            {
                if (ctr.Name == ControlComplementariTxt && ClauForanea == true && verificat == true)
                {
                    ctr.Text = this.Text;
                }
            }
                       
        }
        

        private void SWTextbox_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextInput))
            {
                this.Text = "";
            }
            this.BackColor = Color.LightCyan;
            this.ForeColor = Color.Black;
        }

    }
}
