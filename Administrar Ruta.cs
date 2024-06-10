using MySql.Data.MySqlClient;

namespace Escaner_de_Tienda
{
    public partial class Administrar_Ruta : Form
    {
        public Administrar_Ruta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string correo = textBox1.Text;
            string contraseña = textBox2.Text;

            if (textBox1.Text == "")
            {
                MessageBox.Show("ESCRIBE EL COLOR DE RUTA");
            }
            else
            {
                string database = "server=177.230.218.4;user=escanerTienda;database=escanerTienda;port=3306;password=Ferrari1";
                MySqlConnection managment = new MySqlConnection(database);
                try
                {
                    managment.Open();
                    string sql = "UPDATE ruta SET `nombre_cobrador` = '" + contraseña + "' WHERE(`color_ruta` = '" + correo + "')";
                    string sql1 = "UPDATE tienda SET `vendedor` = '" + contraseña + "' WHERE(`color_ruta` = '" + correo + "')";
                    MySqlCommand comandologin = new MySqlCommand(sql, managment);
                    MySqlCommand comandologin1 = new MySqlCommand(sql1, managment);
                    comandologin.ExecuteNonQuery();
                    comandologin1.ExecuteNonQuery();
                    MessageBox.Show("RUTA ACTUALIZADA");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    button1.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("NO SE PUDO CAMBIAR EL COBRADOR, NO EXISTE");
                }
                managment.Close();

            }
        }

        private void Administrar_Ruta_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string colorRuta = textBox1.Text;

            if (colorRuta == "")
            {
                MessageBox.Show("Escribe el color de ruta");
            }
            else
            {
                string database = "server=177.230.218.4;user=escanerTienda;database=escanerTienda;port=3306;password=Ferrari1";
                MySqlConnection connection = new MySqlConnection(database);

                try
                {
                    connection.Open();
                    string sql = "SELECT DISTINCT nombre_cobrador FROM ruta WHERE color_ruta = @colorRuta";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@colorRuta", colorRuta);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read(); // Solo necesitamos la primera fila
                            string nombreCobrador = reader["nombre_cobrador"].ToString();

                            // Mostrar el nombre del cobrador en el TextBox
                            textBox2.Text = nombreCobrador;
                            button1.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron días para el color de ruta proporcionado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar días: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
