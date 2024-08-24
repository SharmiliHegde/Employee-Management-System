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

namespace LoginRegProject2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = id4.Text;
            string b = name4.Text;
            string c = pos4.Text;
            string d = sal4.Text;
            string f = add4.Text;


            SqlConnection con = new SqlConnection("Data Source = Sharmili\\SQLEXPRESS; Initial Catalog =.netandangular3; Integrated Security = True");

            con.Open();

            string query = "INSERT INTO Employee_management(Emp_id,Name,Position,Salary,Address) values ('" + a + "','" + b + "','" + c + "','" + d + "','" + f + "')";


            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();

            MessageBox.Show("Registration Successful", "success");

            id4.Text = "";
            name4.Text = "";
            pos4.Text = "";
            sal4.Text = "";
            add4.Text = "";
        }
    }
}
