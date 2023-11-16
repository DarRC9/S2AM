using System;
using System.Drawing;
using System.Windows.Forms;
using HashUtils;

namespace PracticaHashing
{
    public partial class frmHashing : Form
    {
        public frmHashing()
        {
            InitializeComponent();
        }

        private HashUser hashUser = new HashUser();

        private void frmHashing_Load(object sender, EventArgs e)
        {
            string hashedSalt = hashUser.createSalt();
            string hashedPassword = hashUser.createPassword();

            txtOriginalSalt.Text = hashedSalt;
            txtOriginalPassword.Text = hashedPassword;
        }

        private void btnValida_Click(object sender, EventArgs e)
        {
            string hashedUserPassword = hashUser.validatePassword(txtPassword.Text);
            txtHashedPassword.Text = hashedUserPassword;

            if (hashedUserPassword == txtOriginalPassword.Text)
            {
                lblResult.BackColor = Color.Green;
                lblResult.Text = "Correct";
            } else
            {
                lblResult.BackColor = Color.Red;
                lblResult.Text = "Incorrect";
            }
        }
    }
}
