using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Book_Shop_Management_System
{
    public partial class Add_Book : Form
    {
        public Add_Book()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.net\\Book Shop Management System\\Bookshop.mdf\";Integrated Security=True");
        SqlCommand cmd;

        private void Add_Book_Load(object sender, EventArgs e)
        {
            // Optionally, initialize any required data or settings
        }

        int totalAmount;

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tittletxt.Text) ||
                string.IsNullOrWhiteSpace(authertxt.Text) ||
                string.IsNullOrWhiteSpace(genretxt.Text) ||
                string.IsNullOrWhiteSpace(quantitytxt.Text) ||
                string.IsNullOrWhiteSpace(buypricetxt.Text) ||
                string.IsNullOrWhiteSpace(sellpricetxt.Text))
            {
                MessageBox.Show("Please fill in all fields before adding a book.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if validation fails
            }

            try
            {
                string sql = "INSERT INTO Book(Tittle, Auther, Genre, Quantity, Buyprice, Saleprice, Totalamount) VALUES(@Tittle, @Auther, @Genre, @Quantity, @Buyprice, @Saleprice, @Totalprice)";
                cmd = new SqlCommand(sql, conn);

                try
                {
                    // Perform calculations
                    int quantity = Convert.ToInt32(quantitytxt.Text);
                    int buyPrice = Convert.ToInt32(buypricetxt.Text);
                    totalAmount = quantity * buyPrice;
                }
                catch(FormatException)
                {
                    // Handle any errors if the text fields are not properly formatted
                    MessageBox.Show("Please enter valid numbers in Quantity and Buy Price fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if formatting fails
                }

                cmd.Parameters.AddWithValue("@Tittle", tittletxt.Text);
                cmd.Parameters.AddWithValue("@Auther", authertxt.Text);
                cmd.Parameters.AddWithValue("@Genre", genretxt.Text);
                cmd.Parameters.AddWithValue("@Quantity", quantitytxt.Text);
                cmd.Parameters.AddWithValue("@Buyprice", buypricetxt.Text);
                cmd.Parameters.AddWithValue("@Saleprice", sellpricetxt.Text);
                cmd.Parameters.AddWithValue("@Totalprice", totalAmount); // Ensure this is the total amount displayed

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book is Added\nAdd another Book", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            // Clear all TextBoxes
            tittletxt.Text = "";
            authertxt.Text = "";
            genretxt.Text = "";
            quantitytxt.Text = "";
            buypricetxt.Text = "";
            sellpricetxt.Text = "";
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            // Close current form and show the Book form
            this.Close(); // Close the current form
           
        }
    }
}
