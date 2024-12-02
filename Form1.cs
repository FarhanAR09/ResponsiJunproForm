using System.Data;
using System.Data.Common;
using System.Net.Security;
using Npgsql;

namespace ResponsiJunproForm
{
    public partial class Form1 : Form
    {
        NpgsqlConnection conn;
        string connString = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=responsi_db";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connString);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            bindingSource1.Add(new List<Test>()
            {
                new Test() { Hello = "Hello", World = "World" }
            });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateView(string query)
        {
            try
            {
                conn.Open();

                dataGridView1.DataSource = null;
                var cmd = new NpgsqlCommand(query, conn);
                DataTable dt = new();
                NpgsqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dataGridView1.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DataTable dropdownDt = new DataTable();

        private void UpdateDropdowns()
        {
            try
            {
                conn.Open();

                dropdownDt.Clear();
                dataGridView1.DataSource = null;
                var cmd = new NpgsqlCommand("select nama_departemen from departemen", conn);
                DataTable dt = new();
                NpgsqlDataReader dr = cmd.ExecuteReader();
                dropdownDt.Load(dr);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}