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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        int seconds = 0;

        private void SplashTmr_Tick(object sender, EventArgs e)
        {
            seconds += 1;
            if (seconds > 3)
            {
                SplashTmr.Enabled = false;
                LoginScreen LoginScreen = new LoginScreen();

                this.Hide();
                LoginScreen.Show();

            }

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
