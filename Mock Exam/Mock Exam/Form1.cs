using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Mock_Exam
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=tcp:PCENG1019404,1433;Initial Catalog=MainDatabase;User ID=sa;Password=Password1");
        public Form1()
        {
            InitializeComponent();
        }

        private void bttn_add_Click(object sender, EventArgs e)
        {
            Add addopen = new Add();
            addopen.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDatabaseDataSet.Main_table' table. You can move, or remove it, as needed.
            this.main_tableTableAdapter.Fill(this.mainDatabaseDataSet.Main_table);
            // TODO: This line of code loads data into the 'test_databaseDataSet.testing' table. You can move, or remove it, as needed.
            this.testingTableAdapter.Fill(this.test_databaseDataSet.testing);

        }

        private void bttn_search_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "Select * From [Main_table] WHERE [type] LIKE '" + textBox1.Text + "%'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void bttn_update_Click(object sender, EventArgs e)
        {
            this.testingTableAdapter.Fill(this.test_databaseDataSet.testing);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bttn_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
