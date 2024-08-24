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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace LoginRegProject2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string a = id5.Text;
            string b = name5.Text;
            string c = pos5.Text;
            string d = sal5.Text;
            string f = add5.Text;


            SqlConnection con = new SqlConnection("Data Source = Sharmili\\SQLEXPRESS; Initial Catalog =.netandangular3; Integrated Security = True");

            con.Open();

            string sql = "update Employee_management set Name=@nm,Position=@pos,Salary=@sl,Address=@adds where Emp_id=@id";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("nm", b);
            cmd.Parameters.AddWithValue("pos", c);
            cmd.Parameters.AddWithValue("sl", d);
            cmd.Parameters.AddWithValue("adds", f);
            cmd.Parameters.AddWithValue("id", a);

            int count = cmd.ExecuteNonQuery();

            if (count != 0)
            {
                MessageBox.Show("Data updated succesfully", "Success");
            }
            else
            {
                MessageBox.Show("Invalid name", "Error");
            }

            id5.Text = "";
            name5.Text = "";
            pos5.Text = "";
            sal5.Text = " ";
            add5.Text = " ";    

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
