using MySql.Data.MySqlClient;

namespace Escaner_de_Tienda
{
    public partial class Registrar_Ruta : Form
    {
        public Registrar_Ruta()
        {
            InitializeComponent();

        }

        private void Registrar_Ruta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("ASIGNA UN COBRADOR, EL ORIGEN Y EL DESTINO");
            }
            else
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("POR FAVOR, ESCRIBE EL COBRADOR QUE QUIERES ASIGNAR");
                }
                if (textBox2.Text == "")
                {
                    MessageBox.Show("POR FAVOR, ESCRIBE EL DIA DE LA RUTA");
                }
                if (textBox4.Text == "")
                {
                    MessageBox.Show("POR FAVOR, ESCRIBE EL COLOR DE LA RUTA");
                }
                else
                {
                    Home home = new Home();
                    string database = "server=208.109.68.135;user=escanerTienda;database=escanerTienda;port=3306;password=Ferrari1";
                    MySqlConnection login = new MySqlConnection(database);
                    MySqlConnection registrar = new MySqlConnection(database);
                    try
                    {
                        login.Open();
                        registrar.Open();
                        string sqlregistrar = "INSERT INTO ruta (`nombre_cobrador`, `dia`,`color_ruta`) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox4.Text + "')";
                        MySqlCommand registro = new MySqlCommand(sqlregistrar, registrar);
                        registro.ExecuteNonQuery();
                        MessageBox.Show("RUTA REGISTRADA");
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
