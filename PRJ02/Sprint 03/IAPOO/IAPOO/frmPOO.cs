using Missatges;
using System.Windows.Forms;


namespace PCBRecuperacio
{
    public partial class frmPOO : Form
    {
        public frmPOO()
        {
            InitializeComponent();
        }
        
        MissatgeHeredat missatge = new MissatgeHeredat();

        private void btnHolaOriginal_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(missatge.salutacio());
        }

        private void btnHola1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(missatge.salutacio(txtNom.Text));
        }

        private void btnHola2_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(missatge.salutacio(txtNom.Text, cmbBandol.Text));
        }

        private void btnAdeuOriginal_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(missatge.comiatCatala());
        }

        private void btnAdeu1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(missatge.comiat());
        }
    }
}
