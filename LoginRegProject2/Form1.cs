using System.Data.SqlClient;

namespace LoginRegProject2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

             this.Hide();
            Form2 obj = new Form2();
            obj.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = name1.Text;
            string b = email1.Text;
            string c= pass1.Text;

            SqlConnection con = new SqlConnection("Data Source = Sharmili\\SQLEXPRESS; Initial Catalog =.netandangular3; Integrated Security = True");
            con.Open();

            string sql = "SELECT * FROM LoginRegister WHERE name=@nm  and email=@em and password=@pass";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nm", "a");
            cmd.Parameters.AddWithValue("@em", "b");
            cmd.Parameters.AddWithValue("@pass","c");

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            int count = cmd.ExecuteNonQuery();

            if (count != 0)
            {
               MessageBox.Show("login sucessfully", "sucess");

            }
            else
            {
                MessageBox.Show("Invalied Detials", "Error");
            }

            this.Hide();
            Form3 obj = new Form3();
            obj.Show();

        }
    }
}
