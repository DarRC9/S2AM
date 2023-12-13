using System.Windows.Forms;

namespace PCBRecuperacio
{
    public partial class frmPOO : Form
    {
        public frmPOO()
        {
            InitializeComponent();
        }
        Missatges.MissatgeHeredat missatge = new Missatges.MissatgeHeredat();

        private void btnHolaOriginal_Click(object sender, System.EventArgs e)
        {
            string mis = missatge.salutacio();
            MessageBox.Show(mis);
        }

        private void btnHola1_Click(object sender, System.EventArgs e)
        {
            string mis = missatge.salutacio(txtNom.Text);
            MessageBox.Show(mis);

        }

        private void btnHola2_Click(object sender, System.EventArgs e)
        {
            string mis = missatge.salutacio(txtNom.Text, cmbBandol.Text);
            MessageBox.Show(mis);

        }

        private void btnAdeuOriginal_Click(object sender, System.EventArgs e)
        {
            string mis = missatge.comiatCatala();
            MessageBox.Show(mis);


        }

        private void btnAdeu1_Click(object sender, System.EventArgs e)
        {
            string mis = missatge.comiat();
            MessageBox.Show(mis);

        }
    }
}
