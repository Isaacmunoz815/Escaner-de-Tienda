using MySql.Data.MySqlClient;

namespace Escaner_de_Tienda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string correo = textBox1.Text;
            string contraseña = textBox2.Text;

            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("RELLENA TODOS LOS CAMPOS, PLEASE");
            }
            else
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("TE FALTA EL CORREO");
                }
                if (textBox2.Text == "")
                {
                    MessageBox.Show("TE FALTA TU CONTRASEÑA");
                }
                else
                {
                    Home home = new Home();
                    string database = "server=208.109.68.135;user=escanerTienda;database=escanerTienda;port=3306;password=Ferrari1";
                    MySqlConnection login = new MySqlConnection(database);
                    try
                    {
                        login.Open();
                        string sql = "SELECT * FROM usuarios WHERE MAIL='" + correo + "' AND PASSWORD='" + contraseña + "';";
                        MySqlCommand comandologin = new MySqlCommand(sql, login);
                        MySqlDataReader lectura = comandologin.ExecuteReader();
                        if (lectura.HasRows)
                        {
                            MessageBox.Show("ACCESO APROBADO");
                            home.Show();
                            this.Hide();
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
                    login.Close();

                }
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrar registrar = new Registrar();
            registrar.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}