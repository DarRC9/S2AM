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


namespace CustomControls
{
    public partial class frmCustomControls : Form
    {
        public frmCustomControls()
        {
            InitializeComponent();
        }

        private void SWCodi_Leave(object sender, EventArgs e)
        {

        }



        //private void TextTxt_Leave(object sender, EventArgs e)
        //{
        //    Regex rgx_txt = new Regex(@"^[a-zA-Z]+$");
        //    string input = TextTxt.Text;

        //    if (input == "")
        //    {
        //        TextTxt.BackColor = Color.White;
        //        TextTxt.ForeColor = Color.Black;
        //        return;
        //    }
        //    else
        //    {
        //        TextTxt.ForeColor = Color.White;
        //        if (rgx_txt.IsMatch(input))
        //        {
        //            TextTxt.BackColor = Color.Green;
        //        }
        //        else
        //        {
        //            TextTxt.BackColor = Color.Red;
        //        }
        //    }
        //}

        //private void CodiTxt_Leave(object sender, EventArgs e)
        //{
        //    Regex rgx_cod = new Regex(@"^[A-Z]{4}\\-\\d{3}\\/[13579][AEIOU]$");
        //    string input = CodiTxt.Text;

        //    if (input == "")
        //    {
        //        CodiTxt.BackColor = Color.White;
        //        CodiTxt.ForeColor = Color.Black;
        //        return;
        //    }
        //    else
        //    {
        //        CodiTxt.ForeColor = Color.White;
        //        if (rgx_cod.IsMatch(input))
        //        {
        //            CodiTxt.BackColor = Color.Green;
        //        }
        //        else
        //        {
        //            CodiTxt.BackColor = Color.Red;
        //        }
        //    }            
        //}

        //private void NumeroTxt_Leave(object sender, EventArgs e)
        //{
        //    Regex rgx_num = new Regex(@"^-?\d+(\.\d+)?$");
        //    string input = NumeroTxt.Text;

        //    if (input == "")
        //    {
        //        NumeroTxt.BackColor = Color.White;
        //        NumeroTxt.ForeColor = Color.Black;
        //        return;
        //    }
        //    else
        //    {
        //        NumeroTxt.ForeColor = Color.White;
        //        if (rgx_num.IsMatch(input))
        //        {
        //            NumeroTxt.BackColor = Color.Green;
        //        }
        //        else
        //        {
        //            NumeroTxt.BackColor = Color.Red;
        //        }
        //    }
        //}
    }
}
