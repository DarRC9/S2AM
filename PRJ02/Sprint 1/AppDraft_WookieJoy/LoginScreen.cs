using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDraft_WookieJoy
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click_1(object sender, EventArgs e)
        {
            if (UsernameTxt.Text == "DR123" && PasswordTxt.Text == "12345")
            {
                MainScreen mainScreen = new MainScreen();
                this.Hide();
                mainScreen.Show();
            }
        }
    }
}
