using System;
using System.Collections;
using System.Windows.Forms;
using ExcepcionsClimatiques;

namespace PracticaExcepcions
{
    public partial class frmClima : Form
    {
        public frmClima()
        {
            InitializeComponent();
        }

        private int initialNumber;

        private void btnStart_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            initialNumber = random.Next(101);
            tcbTemperature.Value = initialNumber;
            lblHumitat.Text = initialNumber.ToString();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            CalculaDades();
        }

        public class TooHighTemperatureException : Exception
        {
            public DateTime IncidentDate { get; }
            public int Temperature { get; }

            public TooHighTemperatureException(string message, DateTime incidentDate, int temperature)
                : base(message)
            {
                IncidentDate = incidentDate;
                Temperature = temperature;
            }
        
        }
        private void CalculaDades()
        {
            try
            {
                int temperaturaFromTextBox = int.Parse(txtTemperatura.Text);
                int temperaturaFromTrackBar = tcbTemperature.Value;

                if (temperaturaFromTextBox > 50)
                {
                    throw new TooHighTemperatureException(
                        "General exception: temperature too high!",
                        DateTime.Now,
                        temperaturaFromTextBox
                    );
                }
                else
                {
                    int multiplication = ValorM();
                    int division = ValorD();

                    if (multiplication > 1000)
                    {
                        try
                        {
                            ErrorClima errorClima;

                            if (int.Parse(txtTemperatura.Text) > 30)
                            {
                                errorClima = new ErrorClima("Temperatura alta!", "Engegar el sistema de refrigeració");
                                throw errorClima;

                            } 

                            if (int.Parse(lblHumitat.Text) < 50)
                            {
                                errorClima = new ErrorClima("Humitat molt baixa!", "Engegar el humificador");
                                throw errorClima;

                            }
                        } catch (ErrorClima ec)
                        {
                            MessageBox.Show(ec.Message);
                        }
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error getting value: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (TooHighTemperatureException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show($"Incident date: {ex.IncidentDate}\nTemperature: {ex.Temperature} degrees", "Error Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ValorD()
        {
            int valor = int.Parse(lblHumitat.Text) / int.Parse(txtTemperatura.Text);
            return valor;
        }

        private int ValorM()
        {
            int valor = int.Parse(lblHumitat.Text) * int.Parse(txtTemperatura.Text);
            return valor;
        }
    }
}
