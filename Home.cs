using MySql.Data.MySqlClient;

namespace Escaner_de_Tienda
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            string database = "server=208.109.68.135;user=escanerTienda;database=escanerTienda;port=3306;password=Ferrari1";
            MySqlConnection home = new MySqlConnection(database);
            dataGridView1.Refresh();

            try
            {
                home.Open();

                string sql = "SELECT * FROM tienda ORDER BY id_tienda;";
                MySqlCommand cmd = new MySqlCommand(sql, home);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = rdr.GetString(0);
                        dataGridView1.Rows[n].Cells[1].Value = rdr.GetString(1);
                        dataGridView1.Rows[n].Cells[2].Value = rdr.GetString(2);
                        dataGridView1.Rows[n].Cells[3].Value = rdr.GetString(3);
                        dataGridView1.Rows[n].Cells[4].Value = rdr.GetString(4);
                        dataGridView1.Rows[n].Cells[5].Value = rdr.GetString(5);
                        dataGridView1.Rows[n].Cells[6].Value = rdr.GetString(6);
                        dataGridView1.Rows[n].Cells[7].Value = rdr.GetString(7);
                        dataGridView1.Rows[n].Cells[8].Value = rdr.GetString(8);
                    }
                }
                else
                {
                    MessageBox.Show("NO HAY TIENDAS REGISTRADAS");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            home.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            REGISTRAR_COBRADOR rEGISTRAR_COBRADOR = new REGISTRAR_COBRADOR();
            rEGISTRAR_COBRADOR.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registrar_Ruta Registrar_Ruta = new Registrar_Ruta();
            Registrar_Ruta.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Administrar_Ruta administrar_Ruta = new Administrar_Ruta();
            administrar_Ruta.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Administrar_Cobrador administrar_Cobrador = new Administrar_Cobrador();
            administrar_Cobrador.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Administrar_Tienda administrar_tienda = new Administrar_Tienda();
            administrar_tienda.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MOSTRAR_RUTAS mostrar_rutas = new MOSTRAR_RUTAS();
            mostrar_rutas.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MOSTRAR_COBRADORES mOSTRAR_COBRADORES = new MOSTRAR_COBRADORES();
            mOSTRAR_COBRADORES.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Registrar_Tienda registrar_Tienda = new Registrar_Tienda();
            registrar_Tienda.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string database = "server=208.109.68.135;user=escanerTienda;database=escanerTienda;port=3306;password=Ferrari1";
            MySqlConnection home = new MySqlConnection(database);

            try
            {
                home.Open();

                string sql = "SELECT * FROM escanerTienda.tienda ORDER BY id_tienda;";
                MySqlCommand cmd = new MySqlCommand(sql, home);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = rdr.GetString(0);
                        dataGridView1.Rows[n].Cells[1].Value = rdr.GetString(1);
                        dataGridView1.Rows[n].Cells[2].Value = rdr.GetString(2);
                        dataGridView1.Rows[n].Cells[3].Value = rdr.GetString(3);
                        dataGridView1.Rows[n].Cells[4].Value = rdr.GetString(4);
                        dataGridView1.Rows[n].Cells[5].Value = rdr.GetString(5);
                        dataGridView1.Rows[n].Cells[6].Value = rdr.GetString(6);
                    }
                }
                else
                {
                    MessageBox.Show("NO HAY TIENDAS REGISTRADAS");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            home.Close();
            dataGridView1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            string database = "server=208.109.68.135;user=escanerTienda;database=escanerTienda;port=3306;password=Ferrari1";
            MySqlConnection home = new MySqlConnection(database);
            home.Open();

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
                // El resto de tu código...
                // Obtiene el ID o alguna columna única de la fila seleccionada
                string id = filaSeleccionada.Cells["IDTIENDA"].Value.ToString();

                // Crea la consulta SQL para actualizar la base de datos
                string query = $"UPDATE tienda SET estatus_cobro = 'pendiente', monto_cobro = NULL WHERE id_tienda = {id}";

                // Ejecuta la consulta SQL
                MySqlCommand cmd = new MySqlCommand(query, home);
                cmd.ExecuteNonQuery();
                MessageBox.Show("TIENDA CAMBIADA A PENDIENTE");
                home.Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila primero.");
            }



        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Home home = new Home();
            form1.Show();
            home.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                {
                    // Escribir los encabezados de las columnas
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        writer.Write(dataGridView1.Columns[i].HeaderText);
                        if (i < dataGridView1.Columns.Count - 1)
                        {
                            writer.Write(",");
                        }
                    }
                    writer.WriteLine();

                    // Escribir las filas
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            for (int i = 0; i < row.Cells.Count; i++)
                            {
                                writer.Write(row.Cells[i].Value);
                                if (i < row.Cells.Count - 1)
                                {
                                    writer.Write(",");
                                }
                            }
                            writer.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
