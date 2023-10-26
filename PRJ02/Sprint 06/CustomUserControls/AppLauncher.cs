using System;
using System.IO;
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
        
        //private string projectDirectory = System.IO.Directory.GetCurrentDirectory();

        //public string PicDir
        //{
        //    get { return projectDirectory; }
        //    set { projectDirectory = value; }
        //}

        public string Classe { get; set; } = "";
        public string Form { get; set; } = "";
        public string Desc { get; set; } = "";
        

        private void AppLauncherLabel_Click(object sender, EventArgs e)
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

        private void AppLauncher_Load(object sender, EventArgs e)
        {
            this.AppLauncherLabel.Text = this.Desc;
            //this.FindForm().BackgroundImage = Image.FromFile(System.IO.File.ReadAllText(this.PicDir));
        }
    }
}
