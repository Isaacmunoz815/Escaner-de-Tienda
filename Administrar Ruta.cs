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
                string database = "server=208.109.68.135;user=escanerTienda;database=escanerTienda;port=3306;password=Ferrari1";
                MySqlConnection managment = new MySqlConnection(database);
                try
                {
                    managment.Open();
                    string sql = "UPDATE ruta SET `nombre_cobrador` = '" + contraseña + "' WHERE(`color_ruta` = '" + correo + "')";
                    MySqlCommand comandologin = new MySqlCommand(sql, managment);
                    comandologin.ExecuteNonQuery();
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
            string correo = textBox1.Text;
            string contraseña = textBox2.Text;

            if (textBox1.Text == "")
            {
                MessageBox.Show("ESCRIBE EL COLOR DE RUTA");
            }
            else
            {
                string database = "server=208.109.68.135;user=escanerTienda;database=escanerTienda;port=3306;password=Ferrari1";
                MySqlConnection managment = new MySqlConnection(database);
                try
                {
                    managment.Open();
                    string sql = "SELECT * FROM ruta WHERE color_ruta= '" + correo + "';";
                    MySqlCommand comandologin = new MySqlCommand(sql, managment);
                    MySqlDataReader lectura = comandologin.ExecuteReader();
                    if (lectura.HasRows)
                    {
                        while (lectura.Read())
                        {
                            textBox2.Text = lectura.GetString(1);
                        }
                        button1.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("NO EXISTE EL USUARIO");


                    }
                    lectura.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                managment.Close();
            }
        }
    }
}
