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

        public bool CampBuit { get; set; } = true;
        public bool ClauForanea { get; set; } = true;

        public string Placeholder
        {
            get { return this.Text; }
            set { this.Text = "Placeholder"; }
        }

        public string ControlComplementariTxt;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.Text = "Placeholder";
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
            Regex rgx_cod = new Regex(@"^[A-Z]{4}\\-\\d{3}\\/[13579][AEIOU]$");
            Regex rgx_num = new Regex(@"^-?\d+(\.\d+)?$");

            if (!CampBuit && string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Input is required.");
                this.Focus();
                return;
            } else if (input == "")
            {
                BackColor = Color.White;
                ForeColor = Color.Gray;
                BackColor = Color.LightGray;
                Text = Placeholder;
                return;
            }
            else
            {
                bool verificat = false;
                if (this.DadaPermesa.ToString() == "Numero")
                {
                    if (rgx_num.IsMatch(input))
                    {
                        verificat = true; 
                    }

                } else if(this.DadaPermesa.ToString() == "Text")
                {
                    if (rgx_txt.IsMatch(input))
                    {
                        verificat = true;
                    }
                } else if (this.DadaPermesa.ToString() == "Codi")
                {
                    if (rgx_cod.IsMatch(input))
                    {
                        verificat = true;
                    }
                }
                if (!verificat)
                {
                    MessageBox.Show("Ha de ser de tipus " + this.DadaPermesa.ToString());
                    this.Focus();
                }
                this.BackColor = Color.White;
            }


            Form frm = this.FindForm();

            foreach (Control ctr in frm.Controls)
            {
                if(ctr.Name == ControlComplementariTxt)
                {
                    ctr.Text = this.Text;
                }
            }
        }
        

        private void SWTextbox_Enter(object sender, EventArgs e)
        {
            this.Text = "";
            this.BackColor = Color.LightCyan;
            this.ForeColor = Color.Black;
        }

    }
}
