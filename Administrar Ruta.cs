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
                MessageBox.Show("ESCRIBE EL ID DE RUTA");
            }
            else
            {
                string database = "server=localhost;user=root;database=escanerTienda;port=3306;password=Ferrari1";
                MySqlConnection managment = new MySqlConnection(database);
                try
                {
                    managment.Open();
                    string sql = "UPDATE `escanertienda`.`ruta` SET `nombre_cobrador` = '" + contraseña + "' WHERE(`id_ruta` = '" + correo + "')";
                    MySqlCommand comandologin = new MySqlCommand(sql, managment);
                    comandologin.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("NO SE PUDO CAMBIAR EL COBRADOR, NO EXISTE");
                }
                managment.Close();
                textBox1.Text = "";
                textBox2.Text = "";

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
                MessageBox.Show("ESCRIBE EL ID DE RUTA");
            }
            else
            {
                string database = "server=localhost;user=root;database=escanerTienda;port=3306;password=Ferrari1";
                MySqlConnection managment = new MySqlConnection(database);
                try
                {
                    managment.Open();
                    string sql = "SELECT * FROM `escanerTienda`.`ruta` WHERE id_ruta= '" + correo + "';";
                    MySqlCommand comandologin = new MySqlCommand(sql, managment);
                    MySqlDataReader lectura = comandologin.ExecuteReader();
                    if (lectura.HasRows)
                    {
                        while (lectura.Read())
                        {
                            textBox2.Text = lectura.GetString(1);
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
