using System;
using System.CodeDom;
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
    public partial class sales : Form
    {
        public sales()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Initialize connection and command
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.net\\Book Shop Management System\\Bookshop.mdf\";Integrated Security=True");
        SqlCommand cmd;
        DataTable dt;
        ShoppingCart cart = new ShoppingCart(); // Initialize ShoppingCart

        private void sales_Load(object sender, EventArgs e)
        {

        }

        private void proceed_Click(object sender, EventArgs e)
        {
            try
            {
                if(cart.GetCartItems().Count == 0)
                {
                    MessageBox.Show("Your cart is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                con.Open();
                foreach(var product in cart.GetCartItems())
                {
                    string sql = "insert into Customer(CustomerName, CustomerAddress, CustomerEmail, CustomerPhone, BookId, BookName, BookGenre, Quantity, Amount, TotalAmount) Values (@CustomerName, @CustomerAddress, @CustomerEmail, @CustomerPhone, @BookId, @BookName, @BookGenre, @Quantity, @Amount, @TotalAmount)";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@CustomerName", custnametxt.Text);
                    cmd.Parameters.AddWithValue("@CustomerAddress", custaddresstxt.Text); // Corrected here
                    cmd.Parameters.AddWithValue("@CustomerEmail", custemailtxt.Text); // Corrected here
                    cmd.Parameters.AddWithValue("@CustomerPhone", custphonetxt.Text); // Corrected here
                    cmd.Parameters.AddWithValue("@BookId", product.ID);
                    cmd.Parameters.AddWithValue("@BookName", product.Name);
                    cmd.Parameters.AddWithValue("@BookGenre", product.Genre);
                    cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
                    cmd.Parameters.AddWithValue("@Amount", product.Price);
                    int quantity = Convert.ToInt32(quantitytxt.Text);
                    int amount = Convert.ToInt32(amounttxt.Text);
                    int totamount = quantity * amount;
                    cmd.Parameters.AddWithValue("@TotalAmount", totamount);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Transaction is Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); // Corrected here
                ClearTextBoxes();
                con.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show("Transaction failed: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = Convert.ToInt32(bookIdtxt.Text);
                string bookName = Booknametxt.Text;
                string genre = genretxt.Text;
                int quantity = Convert.ToInt32(quantitytxt.Text);
                decimal price = Convert.ToDecimal(amounttxt.Text);

                // Create a new product and add it to the cart
                Product product = new Product(productId, bookName, genre, quantity, price);
                cart.AddToCart(product);

                // Display confirmation
                MessageBox.Show("Product added to cart.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayCart(); // Refresh cart display
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayCart()
        {
            cartListBox.Items.Clear();
            foreach(var item in cart.GetCartItems())
            {
                cartListBox.Items.Add(item.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
        private void ClearTextBoxes()
        {
            custnametxt.Text = string.Empty;
            custaddresstxt.Text = string.Empty;
            custemailtxt.Text = string.Empty;
            custphonetxt.Text = string.Empty;
            bookIdtxt.Text = string.Empty;
            Booknametxt.Text = string.Empty;
            genretxt.Text = string.Empty;
            quantitytxt.Text = string.Empty;
            amounttxt.Text = string.Empty;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}