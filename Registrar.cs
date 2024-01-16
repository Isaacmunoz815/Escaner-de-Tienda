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
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombres = textBox1.Text;
            string apellidos = textBox2.Text;
            string correo = textBox3.Text;
            string contrasena = textBox4.Text;
            string birthdate = textBox5.Text;

            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "")
            {
                MessageBox.Show("RELLENA TODOS LOS CAMPOS, PLEASE");
            }
            else
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("TE FALTA LOS NOMBRES");
                }
                if (textBox2.Text == "")
                {
                    MessageBox.Show("TE FALTA LOS APELLIDOS");
                }
                if (textBox3.Text == "")
                {
                    MessageBox.Show("TE FALTA EL CORREO");
                }
                if (textBox4.Text == "")
                {
                    MessageBox.Show("TE FALTA TU CONTRASEÑA");
                }
                if (textBox5.Text == "")
                {
                    MessageBox.Show("TE FALTA LA FECHA DE NACIMIENTO");
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
                        string sql = "SELECT * FROM usuarios WHERE MAIL='" + correo + "' AND PASSWORD='" + contrasena + "';";
                        MySqlCommand comandologin = new MySqlCommand(sql, login);
                        MySqlDataReader lectura = comandologin.ExecuteReader();
                        if (lectura.HasRows)
                        {
                            lectura.Close();
                            MessageBox.Show("EL USUARIO YA EXISTE");
                            login.Close();
                            home.Show();
                            this.Hide();
                        }
                        else
                        {
                            lectura.Close();
                            registrar.Open();
                            string sqlregistrar = "INSERT INTO usuarios (NOMBRES, APELLIDOS, MAIL, PASSWORD, BIRTHDATE) VALUES('" + nombres + "', '" + apellidos + "', '" + correo + "', '" + contrasena + "', '" + birthdate + "');";
                            MySqlCommand registro = new MySqlCommand(sqlregistrar, registrar);
                            registro.ExecuteNonQuery();
                            MessageBox.Show("USUARIO REGISTRADO");
                            registrar.Close();
                            login.Close();


                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }


                }
            }
        }

        private void Registrar_Load(object sender, EventArgs e)
        {

        }
    }
}
