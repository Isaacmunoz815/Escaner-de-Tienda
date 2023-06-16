using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                if(textBox1.Text == "")
                {
                    MessageBox.Show("POR FAVOR, ESCRIBE EL COBRADOR QUE QUIERES ASIGNAR");
                }
                if(textBox2.Text == "")
                {
                    MessageBox.Show("POR FAVOR, ESCRIBE EL ORIGEN DE LA RUTA");
                }
                if(textBox3.Text == "")
                {
                    MessageBox.Show("POR FAVOR, ESCRIBE EL DESTINO DE LA RUTA");
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
                        string sqlregistrar = "INSERT INTO `escanertienda`.`ruta` (`nombre_cobrador`, `Origen`, `Destino`) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "')";
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
