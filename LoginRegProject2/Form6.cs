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

namespace LoginRegProject2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = dname6.Text;

            SqlConnection con = new SqlConnection("Data Source = Sharmili\\SQLEXPRESS; Initial Catalog =.netandangular3; Integrated Security = True");
            con.Open();

            string sql = "delete from Employee_management where name = @na";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@na", a);

            int status = cmd.ExecuteNonQuery();
            if (status > 0)
            {
                MessageBox.Show("Data Deleted Successfully ", "Success");
            } 
            else
            {
                MessageBox.Show("No Record Found", "Error");
            }
        }
    }
}
