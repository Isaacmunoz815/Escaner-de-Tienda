using MySql.Data.MySqlClient;

namespace Escaner_de_Tienda
{
    public partial class Administrar_Cobrador : Form
    {
        public Administrar_Cobrador()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string NOMBRE = textBox6.Text;
            string correo = textBox3.Text;
            string password = textBox2.Text;
            string telefono = textBox4.Text;
            string fecha_nacimiento = textBox5.Text;

            if (textBox1.Text == "")
            {
                MessageBox.Show("ESCRIBE EL NOMBRE DEL COBRADOR");
            }
            else
            {
                string database = "server=177.230.218.4;user=escanerTienda;database=escanerTienda;port=3306;password=Ferrari1";
                MySqlConnection managment = new MySqlConnection(database);
                try
                {
                    managment.Open();

                    string sql = "UPDATE ruta SET nombre_cobrador = '" + NOMBRE + "' WHERE(nombre_cobrador = '" + id + "')";
                    string sql1 = "UPDATE login SET nombre_cobrador = '" + NOMBRE + "', mail = '" + correo + "', password = '" + password + "' WHERE(nombre_cobrador = '" + id + "')";
                    string sql2 = "UPDATE cobrador SET nombre_cobrador = '" + NOMBRE + "', `mail` = '" + correo + "', `telefono` = '" + telefono + "', `birthdate` = '" + fecha_nacimiento + "' WHERE(nombre_cobrador = '" + id + "')";
                    MySqlCommand comandologin = new MySqlCommand(sql, managment);
                    MySqlCommand comandologin1 = new MySqlCommand(sql1, managment);
                    MySqlCommand comandologin2 = new MySqlCommand(sql2, managment);
                    comandologin.ExecuteNonQuery();
                    comandologin1.ExecuteNonQuery();
                    comandologin2.ExecuteNonQuery();
                    MessageBox.Show("DATOS DEL COBRADOR ACTUALIZADOS");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    button2.Enabled = false;
                    button3.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                managment.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string correo = textBox3.Text;
            string telefono = textBox4.Text;
            string fecha = textBox5.Text;

            if (textBox1.Text == "")
            {
                MessageBox.Show("ESCRIBE EL NOMBRE DEL COBRADOR");
            }
            else
            {
                string database = "server=177.230.218.4;user=escanerTienda;database=escanerTienda;port=3306;password=Ferrari1";
                MySqlConnection managment = new MySqlConnection(database);
                try
                {
                    managment.Open();
                    string sql = "SELECT * FROM cobrador WHERE nombre_cobrador= '" + id + "';";
                    MySqlCommand comandologin = new MySqlCommand(sql, managment);
                    MySqlDataReader lectura = comandologin.ExecuteReader();
                    if (lectura.HasRows)
                    {
                        while (lectura.Read())
                        {
                            textBox6.Text = lectura.GetString(1);
                            textBox3.Text = lectura.GetString(2);
                            textBox4.Text = lectura.GetString(3);
                            textBox5.Text = lectura.GetString(4);
                        }
                        lectura.Close();
                        string sql1 = "SELECT password FROM login WHERE nombre_cobrador= '" + id + "';";
                        MySqlCommand comandopass = new MySqlCommand(sql1, managment);
                        MySqlDataReader pass = comandopass.ExecuteReader();
                        if (pass.Read())
                        {
                            textBox2.Text = pass.GetString(0);
                        }
                        pass.Close();

                        button2.Enabled = true;
                        button3.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("NO EXISTE EL USUARIO");
                        lectura.Close();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                managment.Close();
            }
        }

        private void Administrar_Cobrador_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string correo = textBox3.Text;
            string telefono = textBox4.Text;
            string fecha = textBox5.Text;

            string sql = "SELECT * FROM ruta WHERE nombre_cobrador= '" + id + "';";

            string database = "server=177.230.218.4;user=escanerTienda;database=escanerTienda;port=3306;password=Ferrari1";
            MySqlConnection managment = new MySqlConnection(database);
            MySqlCommand comandologin = new MySqlCommand(sql, managment);
            managment.Open();
            try
            {

                MySqlDataReader lectura = comandologin.ExecuteReader();
                if (lectura.HasRows)
                {
                    while (lectura.Read())
                    {
                        textBox3.Text = lectura.GetString(2);
                        textBox4.Text = lectura.GetString(3);
                        textBox5.Text = lectura.GetString(4);
                    }
                    MessageBox.Show("LA RUTA ESTA VINCULADO A ESE COBRADOR");
                    lectura.Close();
                }
                else
                {
                    lectura.Close();
                    string sql2 = "DELETE FROM login WHERE nombre_cobrador='" + id + "';";
                    string sql1 = "DELETE FROM cobrador WHERE nombre_cobrador='" + id + "';";
                    MySqlCommand comandologin2 = new MySqlCommand(sql2, managment);
                    MySqlCommand comandologin1 = new MySqlCommand(sql1, managment);
                    comandologin2.ExecuteNonQuery();
                    comandologin1.ExecuteNonQuery();
                    MessageBox.Show("COBRADOR ELIMINADO");
                    textBox1.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    button2.Enabled = false;
                    button3.Enabled = false;


                }
                managment.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
