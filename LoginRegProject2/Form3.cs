using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegProject2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 obj = new Form4();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 obj = new Form5();
            obj.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 obj = new Form6();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = Sharmili\\SQLEXPRESS; Initial Catalog =.netandangular3; Integrated Security = True");
            con.Open();

            string sql = "select * from Employee_management";

            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                StringBuilder data = new StringBuilder();
                while (r.Read())
                {

                    int Emp_id = r.GetInt32(r.GetOrdinal("Emp_id"));
                    string Name = r.GetString(r.GetOrdinal("Name"));
                    string Position = r.GetString(r.GetOrdinal("Position"));
                    int Salary = r.GetInt32(r.GetOrdinal("Salary"));
                    string Address = r.GetString(r.GetOrdinal("Address"));



                    data.AppendLine($"Emp_id:{Emp_id},Name:{Name}, Position:{Position}, Salary:{Salary},Address:{Address}");
                }
                MessageBox.Show(data.ToString(), "All data");

            }
        }
    }
}
