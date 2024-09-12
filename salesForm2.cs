using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Book_Shop_Management_System
{
    public partial class salesForm2 : Form
    {
        public salesForm2()
        {
            InitializeComponent();
        }

        private SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.net\\Book Shop Management System\\Bookshop.mdf\";Integrated Security=True");

        private void salesForm2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData(string filter = "")
        {
            try
            {
                conn.Open();
                String sql = "SELECT BookId, BookName, BookGenre, Quantity, TotalAmount FROM Customer";

                if(!string.IsNullOrEmpty(filter))
                {
                    sql += " WHERE BookName LIKE @filter OR BookId LIKE @filter";
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
                dataGridView1.Refresh(); // Add this line to refresh the DataGridView
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error loading sales data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            string filter = searchtextbox.Text.Trim();
            LoadData(filter);
        }

        private void searchtextbox_TextChanged(object sender, EventArgs e)
        {
            string filter = searchtextbox.Text.Trim();
            LoadData(filter);
        }
    }
}