using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace CustomUserControls
{
    public partial class AppLauncher : UserControl
    {
        public AppLauncher()
        {
            InitializeComponent();
        }

        public string Classe { get; set; } = "";
        public string Form { get; set; } = "";
        public string Desc { get; set; } = "";

        private void LaunchBtn_Click(object sender, EventArgs e)
        {

            Assembly ensamblat = Assembly.LoadFrom(Classe + ".dll");

            Object dllBD;
            Type tipus;

            tipus = ensamblat.GetType(Classe + "." + Form);
            dllBD = Activator.CreateInstance(tipus);

            Form frm = (Form)dllBD;

            frm.Text = Desc;
            frm.Show();


        }
    }
}
