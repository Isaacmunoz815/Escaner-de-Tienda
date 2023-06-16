using Microsoft.VisualBasic;
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
    public partial class Administrar_Cobrador : Form
    {
        public Administrar_Cobrador()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string nombre = textBox2.Text;
            string correo = textBox3.Text;
            string telefono = textBox4.Text;
            string fecha_nacimiento = textBox5.Text;

            if (textBox1.Text == "")
            {
                MessageBox.Show("ESCRIBE EL ID DE COBRADOR");
            }
            else
            {
                string database = "server=localhost;user=root;database=escanerTienda;port=3306;password=Ferrari1";
                MySqlConnection managment = new MySqlConnection(database);
                try
                {
                    managment.Open();
                    string sql = "UPDATE `escanertienda`.`cobrador` SET `nombre_cobrador` = '" + nombre + "', `mail` = '" + correo + "', `telefono` = '" + telefono + "', `birthdate` = '" + fecha_nacimiento + "' WHERE(`id_cobrador` = '" + id + "')";
                    MySqlCommand comandologin = new MySqlCommand(sql, managment);
                    comandologin.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("NO SE PUDO MODIFICAR LOS DATOS DEL COBRADOR");
                }
                managment.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string nombre = textBox2.Text;
            string correo = textBox3.Text;
            string telefono = textBox4.Text;
            string fecha = textBox5.Text;

            if (textBox1.Text == "")
            {
                MessageBox.Show("ESCRIBE EL ID DE COBRADOR");
            }
            else
            {
                string database = "server=localhost;user=root;database=escanerTienda;port=3306;password=Ferrari1";
                MySqlConnection managment = new MySqlConnection(database);
                try
                {
                    managment.Open();
                    string sql = "SELECT * FROM `escanerTienda`.`cobrador` WHERE id_cobrador= '" + id + "';";
                    MySqlCommand comandologin = new MySqlCommand(sql, managment);
                    MySqlDataReader lectura = comandologin.ExecuteReader();
                    if (lectura.HasRows)
                    {
                        while (lectura.Read())
                        {
                            textBox2.Text = lectura.GetString(1);
                            textBox3.Text = lectura.GetString(2);
                            textBox4.Text = lectura.GetString(3);
                            textBox5.Text = lectura.GetString(4);
                        }

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
