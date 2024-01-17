using MySql.Data.MySqlClient;

namespace Escaner_de_Tienda
{
    public partial class MOSTRAR_RUTAS : Form
    {
        public MOSTRAR_RUTAS()
        {
            InitializeComponent();
            string database = "server=208.109.68.135;user=escanerTienda;database=escanerTienda;port=3306;password=Ferrari1";
            MySqlConnection home = new MySqlConnection(database);

            try
            {
                home.Open();

                string sql = "SELECT * FROM ruta ORDER BY color_ruta;";
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
                    }
                }
                else
                {
                    MessageBox.Show("NO HAY RUTAS REGISTRADAS");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            home.Close();
        }

        private void MOSTRAR_RUTAS_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
