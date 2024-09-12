using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Book_Shop_Management_System
{
    public partial class loginform : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.net\\Book Shop Management System\\Bookshop.mdf\";Integrated Security=True");
        SqlCommand cmd;

        public loginform()
        {
            InitializeComponent();
        }

        private void loginform_Load(object sender, EventArgs e)
        {
            // Any initialization code if needed
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate if both fields are filled
            if(string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                con.Open();
                string sql = "SELECT COUNT(1) FROM [User] WHERE Username=@Username AND Password=@Password";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if(count == 1)
                {
                    MessageBox.Show("Login is Success\n Welcome to Book", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Book book = new Book(textBox1.Text);
                    book.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password is Wrong", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred during login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
