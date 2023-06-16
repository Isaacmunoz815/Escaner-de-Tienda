using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escaner_de_Tienda
{
    public partial class MOSTRAR_RUTAS : Form
    {
        public MOSTRAR_RUTAS()
        {
            InitializeComponent();
            string database = "server=localhost;user=root;database=escanerTienda;port=3306;password=Ferrari1";
            MySqlConnection home = new MySqlConnection(database);

            try
            {
                home.Open();

                string sql = "SELECT * FROM escanertienda.ruta ORDER BY id_ruta;";
                MySqlCommand cmd = new MySqlCommand(sql, home);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = rdr.GetString(0);
                        dataGridView1.Rows[n].Cells[1].Value = rdr.GetString(1);
                        dataGridView1.Rows[n].Cells[2].Value = rdr.GetString(2);
                        dataGridView1.Rows[n].Cells[3].Value = rdr.GetString(3);
                    }
                }
                else
                {
                    MessageBox.Show("NO HAY RUTAS REGISTRADAS");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            home.Close();
        }

        private void MOSTRAR_RUTAS_Load(object sender, EventArgs e)
        {

        }
    }
}
