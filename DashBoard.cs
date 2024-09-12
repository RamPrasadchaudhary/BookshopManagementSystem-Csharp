using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Book_Shop_Management_System
{
    public partial class DashBoard : Form
    {
        SqlConnection conn= new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.net\\Book Shop Management System\\Bookshop.mdf\";Integrated Security=True");
        SqlCommand cmd;
        public DashBoard()
        {
            InitializeComponent();
        }
        int count;
        private void DashBoard_Load(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                  
                    string query = "SELECT COUNT(*) FROM [User]"; // Replace 'YourTableName' with your actual table name
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int rowCount = (int)cmd.ExecuteScalar();
                    label1.Text += $" : {rowCount}"; 
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occured during fetching: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


            try
            {
             
                string query = "SELECT COUNT(*) FROM Book "; // Replace 'YourTableName' with your actual table name
                SqlCommand cmd = new SqlCommand(query, conn);
                int rowCount = (int)cmd.ExecuteScalar();
                label3.Text += $" : {rowCount}";
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occured during fetching " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






            try
            {
                // Assuming 'conn' is your open SqlConnection
                string query = "SELECT COUNT(DISTINCT CustomerName) FROM Customer"; // Adjust 'CustomerName' to your actual column name
                SqlCommand cmd = new SqlCommand(query, conn);

                int uniqueCustomerCount = (int)cmd.ExecuteScalar();
                label4.Text += $" : {uniqueCustomerCount}";
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred during fetching: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

            try
            {
                // Assuming 'conn' is your open SqlConnection
                string query = @"
        SELECT SUM(CAST(Saleprice AS DECIMAL(18, 2)) - CAST(Buyprice AS DECIMAL(18, 2))) AS TotalProfit 
        FROM Book";
                SqlCommand cmd = new SqlCommand(query, conn);

                // Execute the query and get the total profit
                decimal totalProfit = (decimal)cmd.ExecuteScalar();

                // Display the total profit in the label
                label5.Text = $"Total Profit: {totalProfit:C}"; // ':C' formats as currency
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred while fetching data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }


        }



        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
