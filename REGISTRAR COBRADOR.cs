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
                    string database = "server=localhost;user=root;database=escanerTienda;port=3306;password=Ferrari1";
                    MySqlConnection login = new MySqlConnection(database);
                    MySqlConnection registrar = new MySqlConnection(database);
                    try
                    {
                        login.Open();
                        registrar.Open();
                        string sqlregistrar = "INSERT INTO `escanertienda`.`cobrador` (`nombre_cobrador`, `mail`, `telefono`, `birthdate`) VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')";
                        MySqlCommand registro = new MySqlCommand(sqlregistrar, registrar);
                        registro.ExecuteNonQuery();
                        MessageBox.Show("COBRADOR REGISTRADO");
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
