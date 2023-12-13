using Missatges;
using System.Windows.Forms;


namespace PCBRecuperacio
{
    public partial class frmPOO : Form
    {
        /// <summary>
        /// Inicialitzacio de el Form frmPOO
        /// </summary>
        public frmPOO()
        {
            InitializeComponent();
        }
        
        MissatgeHeredat missatge = new MissatgeHeredat();
        /// <summary>
        /// Metodo que permite mostrar la el mensaje salutacio
        /// </summary>
        /// <param name="sender">No utiitzat</param>
        /// <param name="e">No utiitzat</param>
        private void btnHolaOriginal_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(missatge.salutacio());
        }
        /// <summary>
        /// Metodo que permite mostrar la el mensaje salutacio pasando un parametro al ser una heredera
        /// </summary>
        /// <param name="sender">No utiitzat</param>
        /// <param name="e">No utiitzat</param>
        private void btnHola1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(missatge.salutacio(txtNom.Text));
        }
        /// <summary>
        /// Metodo que permite pasar dos parametros a salutacio
        /// </summary>
        /// <param name="sender">No utiitzat</param>
        /// <param name="e">No utiitzat</param>
        private void btnHola2_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(missatge.salutacio(txtNom.Text, cmbBandol.Text));
        }
        /// <summary>
        /// Metodo que permite ejecutar comiatCatala cuando btnAdeu sea presionado
        /// </summary>
        /// <param name="sender">No utiitzat</param>
        /// <param name="e">No utiitzat</param>
        private void btnAdeuOriginal_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(missatge.comiatCatala());
        }
        /// <summary>
        /// Metodo que permite ejecutar comiat cuando btnAdeu1 sea presionado
        /// </summary>
        /// <param name="sender">No utiitzat</param>
        /// <param name="e">No utiitzat</param>
        private void btnAdeu1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(missatge.comiat());
        }
    }
}
