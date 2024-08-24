using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LoginRegProject2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = name2.Text;
            string b = email2.Text;
            string c = pass2.Text;

            SqlConnection con = new SqlConnection("Data Source = Sharmili\\SQLEXPRESS; Initial Catalog =.netandangular3; Integrated Security = True");

            con.Open();

            string query = "INSERT INTO LoginRegister(name,email,password) values ('" + a + "','" + b + "','" + c + "')";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();

            MessageBox.Show("Registration Successful", "success");

            name2.Text = "";
            email2.Text = "";
            pass2.Text = "";




        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
