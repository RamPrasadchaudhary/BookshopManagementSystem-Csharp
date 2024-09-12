using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Book_Shop_Management_System
{
    public partial class Book_Record : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.net\\Book Shop Management System\\Bookshop.mdf\";Integrated Security=True");

        public Book_Record()
        {
            InitializeComponent();
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick); // Assign the event handler
        }

        private void Book_Record_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Book", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e) // Update button
        {
            UpdateBookRecord();
        }

        private void button2_Click(object sender, EventArgs e) // Reset button
        {
            ResetFields();
        }

        private void button3_Click(object sender, EventArgs e) // Cancel button
        {
            this.Close();
        }

       

       
        private void ResetFields()
        {
            txttittle.Clear();
            txtauther.Clear();
            txtgenre.SelectedIndex = -1;
            txtquantity.Value = 1;
            txtbuyprice.Clear();
            txtsellprice.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) // Ensure the user clicked a valid row
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Populate text boxes with the row's data
                txttittle.Text = row.Cells["Tittle"].Value?.ToString() ?? string.Empty;
                txtauther.Text = row.Cells["Auther"].Value?.ToString() ?? string.Empty;
                txtgenre.SelectedItem = row.Cells["Genre"].Value?.ToString();
                txtquantity.Value = Convert.ToInt32(row.Cells["Quantity"].Value ?? 1);
                txtbuyprice.Text = row.Cells["BuyPrice"].Value?.ToString() ?? string.Empty;
                txtsellprice.Text = row.Cells["salePrice"].Value?.ToString() ?? string.Empty;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        int totalAmount;
        private void button1_Click_1(object sender, EventArgs e)
        {
            UpdateBookRecord();
        }

        private void UpdateBookRecord()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Book SET Tittle=@Title, Auther=@Author, Genre=@Genre, Quantity=@Quantity, Buyprice=@BuyPrice, Saleprice=@SellPrice, Totalamount=@TotalAmount WHERE BookID=@BookID", con);
                try
                {
                    int quantity = Convert.ToInt32(txtquantity.Value);
                    int buyPrice = Convert.ToInt32(txtbuyprice.Text);
                    totalAmount = quantity * buyPrice;
                }
                catch(FormatException)
                {
                    MessageBox.Show("Please enter valid numbers in Quantity and Buy Price fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cmd.Parameters.AddWithValue("@Title", txttittle.Text);
                cmd.Parameters.AddWithValue("@Author", txtauther.Text);
                cmd.Parameters.AddWithValue("@Genre", txtgenre.Text.ToString());
                cmd.Parameters.AddWithValue("@Quantity", txtquantity.Value);
                cmd.Parameters.AddWithValue("@BuyPrice", Convert.ToDecimal(txtbuyprice.Text));
                cmd.Parameters.AddWithValue("@SellPrice", Convert.ToDecimal(txtsellprice.Text));
                cmd.Parameters.AddWithValue("@TotalAmount", Convert.ToDecimal(totalAmount));
                cmd.Parameters.AddWithValue("@BookID", dataGridView1.SelectedRows[0].Cells[0].Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                LoadData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            SearchBooks();
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            SearchBooks();
        }

        private void SearchBooks()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Book WHERE Tittle LIKE @Title OR Auther LIKE @Author", con);
                cmd.Parameters.AddWithValue("@Title", "%" + textBox3.Text.Trim() + "%");
                cmd.Parameters.AddWithValue("@Author", "%" + textBox3.Text.Trim() + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh(); // Add this line to refresh the DataGridView
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred while fetching data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
