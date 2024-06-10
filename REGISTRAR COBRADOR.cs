using MySql.Data.MySqlClient;

namespace Escaner_de_Tienda
{
    public partial class REGISTRAR_COBRADOR : Form
    {
        public REGISTRAR_COBRADOR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "")
            {
                MessageBox.Show("ESCRIBE TODOS LO CAMPOS DEL COBRADOR");
            }
            else
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("ESCRIBE SU NOMBRE");
                }
                if (textBox2.Text == "")
                {
                    MessageBox.Show("ESCRIBE SU CORREO");
                }
                if (textBox3.Text == "")
                {
                    MessageBox.Show("ESCRIBE SU TELEFONO");
                }
                if (textBox4.Text == "")
                {
                    MessageBox.Show("ESCRIBE LA FECHA DE NACIMIENTO");
                }
                else
                {
                    Home home = new Home();
                    string database = "server=177.230.218.4;user=escanerTienda;database=escanerTienda;port=3306;password=Ferrari1";
                    MySqlConnection login = new MySqlConnection(database);
                    MySqlConnection registrar = new MySqlConnection(database);
                    try
                    {
                        login.Open();
                        registrar.Open();
                        string sqlregistrar = "INSERT INTO cobrador (`nombre_cobrador`, `mail`, `telefono`, `birthdate`) VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')";
                        string sqlregistrar1 = "INSERT INTO logiin (`nombre_cobrador`, `mail`, `passwords`) VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox5.Text + "')";
                        string checkduplicated = "SELECT * From cobrador WHERE mail = '" + textBox2.Text + "';";
                        MySqlCommand checkduplicated1 = new MySqlCommand(checkduplicated, registrar);
                        MySqlDataReader read = checkduplicated1.ExecuteReader();
                        if (read.HasRows)
                        {
                            MessageBox.Show("YA EXISTE UN COBRADOR CON ESE CORREO");
                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";
                            textBox5.Text = "";
                            read.Close();

                        }
                        else
                        {
                            read.Close();
                            MySqlCommand registro = new MySqlCommand(sqlregistrar, registrar);
                            MySqlCommand registro1 = new MySqlCommand(sqlregistrar1, registrar);
                            registro.ExecuteNonQuery();
                            registro1.ExecuteNonQuery();
                            MessageBox.Show("COBRADOR REGISTRADO");
                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";

                        }
                        registrar.Close();
                        login.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
    }
}
