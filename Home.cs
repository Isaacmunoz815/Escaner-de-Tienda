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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            string database = "server=localhost;user=root;database=escanerTienda;port=3306;password=Ferrari1";
            MySqlConnection home = new MySqlConnection(database);

            try
            {
                home.Open();

                string sql = "SELECT * FROM escanertienda.tienda ORDER BY id_ruta;";
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
                        dataGridView1.Rows[n].Cells[4].Value = rdr.GetString(5);
                        dataGridView1.Rows[n].Cells[5].Value = rdr.GetString(6);
                        dataGridView1.Rows[n].Cells[6].Value = rdr.GetString(4);
                        dataGridView1.Rows[n].Cells[7].Value = rdr.GetString(7);
                    }
                }
                else
                {
                    MessageBox.Show("NO HAY TIENDAS REGISTRADAS");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            home.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            REGISTRAR_COBRADOR rEGISTRAR_COBRADOR = new REGISTRAR_COBRADOR();
            rEGISTRAR_COBRADOR.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registrar_Ruta Registrar_Ruta = new Registrar_Ruta();
            Registrar_Ruta.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Administrar_Ruta administrar_Ruta = new Administrar_Ruta();
            administrar_Ruta.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Administrar_Cobrador administrar_Cobrador = new Administrar_Cobrador();
            administrar_Cobrador.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MOSTRAR_RUTAS mostrar_rutas = new MOSTRAR_RUTAS();
            mostrar_rutas.Show();
        }
    }
}
