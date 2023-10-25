using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CustomControls
{
    public partial class Dades : Form
    {
        public Dades()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        string cnx;

        private void Dades_Load(object sender, EventArgs e)
        {
            cnx = "aquí va la cadena de connexió";
            conn = new SqlConnection(cnx);

            SqlDataAdapter adapter;

            string query;
            query = "select * from users";
            adapter = new SqlDataAdapter(query, conn);

            conn.Open();
            DataSet dts = new DataSet();
            adapter.Fill(dts, "Nomtaula");
            conn.Close();

            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {

                }
            }
        }
    }
}
