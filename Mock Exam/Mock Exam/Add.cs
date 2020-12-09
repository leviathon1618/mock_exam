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
using System.IO;
using System.Net;

namespace Mock_Exam
{
    public partial class Add : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=tcp:PCENG1019404,1433;Initial Catalog=MainDatabase;User ID=sa;Password=Password1");
        
        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }


        
        private void bttn_add_Click(object sender, EventArgs e)
        {

            con.Open();
            String query = "INSERT INTO [Main_table] (name,type,path)" +
                "Values" + "('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            textBox4.Text = openFileDialog1.FileName;
            string NewFile = openFileDialog1.FileName.ToString();
            string result;
            result = Path.GetFileName(NewFile);

            
            WebClient myWebClient = new WebClient();
            myWebClient.UploadFile(@"ftp://172.17.81.164/" + result , NewFile);

        }
    }
}
