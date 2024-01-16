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
    public partial class Administrar_Tienda : Form
    {
        public Administrar_Tienda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;

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
                    string sql = "SELECT * FROM tienda WHERE id_tienda= '" + nombre + "';";
                    MySqlCommand comandologin = new MySqlCommand(sql, managment);
                    MySqlDataReader lectura = comandologin.ExecuteReader();
                    if (lectura.HasRows)
                    {
                        while (lectura.Read())
                        {
                            textBox2.Text = lectura.GetString(0);
                            textBox3.Text = lectura.GetString(1);
                            textBox4.Text = lectura.GetString(2);
                            textBox5.Text = lectura.GetString(6);
                            textBox6.Text = lectura.GetString(4);
                        }
                        lectura.Close();

                    }
                    else
                    {
                        MessageBox.Show("NO EXISTE EL USUARIO");


                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                managment.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string vendedor = textBox2.Text;
            string telefono = textBox3.Text;
            string domicilio = textBox4.Text;
            string ruta = textBox5.Text;
            string idtienda = textBox6.Text;

            string database = "server=208.109.68.135;user=escanerTienda;database=escanerTienda;port=3306;password=Ferrari1";
            MySqlConnection managment = new MySqlConnection(database);
            string sql1 = "SELECT * FROM ruta WHERE color_ruta= '" + ruta + "';";
            MySqlCommand comandoruta = new MySqlCommand(sql1, managment);

            if (textBox1.Text == "")
            {
                MessageBox.Show("ESCRIBE EL NOMBRE DE LA TIENDA");
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("ESCRIBE EL VENDEDOR DE LA TIENDA");
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("ESCRIBE EL TELEFONO DE LA TIENDA");
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("ESCRIBE EL DOMICILIO DE LA TIENDA");
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("ESCRIBE LA RUTA DE LA TIENDA");
            }
            else
            {
                try
                {
                    managment.Open();
                    string sql = "UPDATE tienda SET color_ruta = '" + ruta + "', domicilio = '" + domicilio + "', telefono_tienda = '" + telefono + "', vendedor = '" + vendedor + "' , id_tienda = '" + idtienda + "' WHERE(id_tienda = '" + nombre + "')"; MySqlCommand comandologin = new MySqlCommand(sql, managment);
                    MySqlDataReader leerruta = comandoruta.ExecuteReader();

                    if (leerruta.HasRows)
                    {
                        leerruta.Close();
                        comandologin.ExecuteNonQuery();
                        MessageBox.Show("DATOS ACTUALIZADOS Y RUTA CAMBIADA");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";

                    }
                    else
                    {
                        leerruta.Close();
                        MessageBox.Show("ESA RUTA NO EXISTE");

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;

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
                    string sql = "DELETE FROM tienda WHERE id_tienda= '" + nombre + "';";
                    MySqlCommand delete = new MySqlCommand(sql, managment);
                    delete.ExecuteNonQuery();
                    MessageBox.Show("TIENDA ELIMINADA");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";

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
