using MySql.Data.MySqlClient;

namespace Escaner_de_Tienda
{
    public partial class Registrar_Tienda : Form
    {
        public Registrar_Tienda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string colorruta = textBox6.Text;

            if (textBox3.Text == "")
            {
                MessageBox.Show("POR FAVOR, ESCRIBE EL VENDEDOR DE LA TIENDA");
            }
            else
            {
                string database = "server=177.230.218.4;user=escanerTienda;database=escanerTienda;port=3306;password=Ferrari1";
                MySqlConnection login = new MySqlConnection(database);
                try
                {
                    login.Open();
                    string checkroute = "SELECT * FROM ruta WHERE color_ruta = '" + colorruta + "';";
                    string sqlregistrar = "INSERT INTO tienda (`id_tienda`, `vendedor`, `telefono_tienda`, `domicilio`, `estatus_cobro`, `color_ruta`,`dia`,`monto_cobro`) VALUES('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "', '" + textBox5.Text + "', 'PENDIENTE', '" + textBox6.Text + "','" + textBox2.Text + "', '0')";
                    MySqlCommand checarruta = new MySqlCommand(checkroute, login);
                    MySqlCommand registro = new MySqlCommand(sqlregistrar, login);

                    MySqlDataReader leerruta = checarruta.ExecuteReader();
                    if (leerruta.HasRows)
                    {
                        leerruta.Close();
                        registro.ExecuteNonQuery();
                        MessageBox.Show("TIENDA REGISTRADA");
                        textBox1.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("NO EXISTE LA RUTA QUE ESPECIFICASTE");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                login.Close();
            }
        }

        private void Registrar_Tienda_Load(object sender, EventArgs e)
        {

        }
    }
}
