using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace REGEX_PRACTICE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Verificar1Btn_Click(object sender, EventArgs e)
        {
            Regex rgx = new Regex(TelefonRgxTxt.Text);
            bool verificacio = rgx.IsMatch(TelefonTxt.Text);
            if (verificacio)
            {
                verificationPanel1.BackColor = Color.Green;
            }else
            {
                verificationPanel1.BackColor = Color.Red;
            }
            // ^\(?\+\d{1,3}\)?\-\d{3}\.\d{2}\.\d{2}\.\d{2}$  
            // \(?     Expressio que veu si te o no un "(" ,
            // \+      ha de tenir un +,
            // \d{1,3} ha de tenir numero entre {1,3} de llarg,
            // \)?     mira si te o no ")",
            // \-      ha de tenir "-",
            // \d{3}   ha de tenir 3 numeros,
            // \.      ha de tenir ".",
            // \d{2}   ha de tenir 2 numeros...
        }

        private void Verificar2Btn_Click(object sender, EventArgs e)
        {
            Regex rgx = new Regex(EmailRgxTxt.Text);
            bool verificacio = rgx.IsMatch(EmailTxt.Text);
            if (verificacio)
            {
                verificationPanel2.BackColor = Color.Green;
            } else
            {
                verificationPanel2.BackColor = Color.Red;
            }
            // ^[^\d]\w*\.\w+\@[^\d]\w+\.[a-zA-Z]{2,3}$
            // [^\d]           Expressio que veu que no hi hagi un numero com a primer character,
            // \w*             veu que pugin haber entre 0 o mes valor alfanumerics,
            // \.              ha de tenir ".",
            // \w+             pot tenir entre 1 o mes valor alfanumerics,
            // \@              ha de tenir "@"
            // [^\d]           no ha de tenir numeros
            // \w+             pot tenir entre 1 o mes valor alfanumerics,
            // \.              ha de tenir ".",
            // [a-zA-Z]{2,3}   mira si els 2/3 seguents caracters son lletres
        }

        private void Verificar3Btn_Click(object sender, EventArgs e)
        {
            Regex rgx = new Regex(CodiRgxTxt.Text);
            bool verificacio = rgx.IsMatch(CodiTxt.Text);
            if (verificacio)
            {
                verificationPanel3.BackColor = Color.Green;
            }else
            {
                verificationPanel3.BackColor = Color.Red;
            }
            // ^[A - Z]{ 4}\-\d{ 3}\/[13579][AEIOU]$
            // [A - Z] {4} Expressio que mira si els quatre primers characters son lletres mayuscules,
            // \-          ha de tenir "-",
            // \d{ 3}      ha de tenir 3 numeros,
            // \/          ha de tenir "/",
            // [13579]     ha de ser un numero senar,
            // [AEIOU]     ha de ser una vocal mayuscula 
        }
    }
}
