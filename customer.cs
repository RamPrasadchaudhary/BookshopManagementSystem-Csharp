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

namespace Book_Shop_Management_System
{
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.net\\Book Shop Management System\\Bookshop.mdf\";Integrated Security=True");

        private void customer_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData(string filter = "")
        {
            try
            {
                conn.Open();
                string sql = "SELECT CustomerName, CustomerAddress, CustomerEmail, CustomerPhone, BookId, TotalAmount FROM Customer";

                if(!string.IsNullOrEmpty(filter))
                {
                    sql += " WHERE CustomerName LIKE @filter OR CustomerEmail LIKE @filter OR CustomerPhone LIKE @filter";
                }

                SqlCommand command = new SqlCommand(sql, conn);
                if(!string.IsNullOrEmpty(filter))
                {
                    command.Parameters.AddWithValue("@filter", "%" + filter + "%");
                }

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error loading customer data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string filter = textBox1.Text.Trim();
            LoadData(filter);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filter = textBox1.Text.Trim();
            LoadData(filter);
        }
    }
}