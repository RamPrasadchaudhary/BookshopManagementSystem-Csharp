using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Book_Shop_Management_System
{
    public partial class user : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.net\\Book Shop Management System\\Bookshop.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public user()
        {
            InitializeComponent();

            // Register the CellClick event handler for dataGridView1
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
        }

        private void user_Load(object sender, EventArgs e)
        {
            LoadData(); // Load all data on form load
        }

        private void button1_Click(object sender, EventArgs e) // Add button
        {
            // Check if any of the required text boxes are empty
            if(string.IsNullOrWhiteSpace(usertxt.Text) ||
                string.IsNullOrWhiteSpace(addresstxt.Text) ||
                string.IsNullOrWhiteSpace(phonetxt.Text) ||
                string.IsNullOrWhiteSpace(username.Text) ||
                string.IsNullOrWhiteSpace(passwordtxt.Text))
            {
                MessageBox.Show("Please fill in all fields before adding a user.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if validation fails
            }

            try
            {
                string sql = "INSERT INTO [User](Name, Address, Phone, Username, Password) VALUES (@Name, @Address, @Phone, @Username, @Password)";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Name", usertxt.Text);
                cmd.Parameters.AddWithValue("@Address", addresstxt.Text);
                cmd.Parameters.AddWithValue("@Phone", phonetxt.Text);
                cmd.Parameters.AddWithValue("@Username", username.Text);
                cmd.Parameters.AddWithValue("@Password", passwordtxt.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearTextBoxes(this); // Clear text boxes after adding user
                LoadData();  // Refresh the data in DataGridView
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void resetButton_Click(object sender, EventArgs e) // Reset button
        {
            ClearTextBoxes(this); // Clear all text boxes when Reset button is clicked
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = searchTextBox.Text.Trim();
            LoadData(searchQuery); // Update DataGridView based on search query
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) // Ensure click is not on the header
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                usertxt.Text = row.Cells["Name"].Value?.ToString();    // Name
                addresstxt.Text = row.Cells["Address"].Value?.ToString(); // Address
                phonetxt.Text = row.Cells["Phone"].Value?.ToString();   // Phone
                username.Text = row.Cells["Username"].Value?.ToString();   // Username
                passwordtxt.Text = row.Cells["Password"].Value?.ToString(); // Password
            }
        }

        private void ClearTextBoxes(Control parent)
        {
            foreach(Control control in parent.Controls)
            {
                if(control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if(control.HasChildren)
                {
                    ClearTextBoxes(control);
                }
            }
        }

        private void LoadData(string searchQuery = "")
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM [User]";
                if(!string.IsNullOrEmpty(searchQuery))
                {
                    query += " WHERE Name LIKE @Search OR Username LIKE @Search";
                }
                da = new SqlDataAdapter(query, con);
                if(!string.IsNullOrEmpty(searchQuery))
                {
                    da.SelectCommand.Parameters.AddWithValue("@Search", "%" + searchQuery + "%");
                }
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void update_Click(object sender, EventArgs e) // Update button
        {
            // Ensure a row is selected
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if any of the required text boxes are empty
            if(string.IsNullOrWhiteSpace(usertxt.Text) ||
                string.IsNullOrWhiteSpace(addresstxt.Text) ||
                string.IsNullOrWhiteSpace(phonetxt.Text) ||
                string.IsNullOrWhiteSpace(username.Text) ||
                string.IsNullOrWhiteSpace(passwordtxt.Text))
            {
                MessageBox.Show("Please fill in all fields before updating a user.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if validation fails
            }

            try
            {
                string sql = "UPDATE [User] SET Name=@Name, Address=@Address, Phone=@Phone, Username=@Username, Password=@Password WHERE UserID=@UserID";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Name", usertxt.Text);
                cmd.Parameters.AddWithValue("@Address", addresstxt.Text);
                cmd.Parameters.AddWithValue("@Phone", phonetxt.Text);
                cmd.Parameters.AddWithValue("@Username", username.Text);
                cmd.Parameters.AddWithValue("@Password", passwordtxt.Text);
                cmd.Parameters.AddWithValue("@UserID", dataGridView1.SelectedRows[0].Cells["UserID"].Value); // Assuming UserID is the primary key
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearTextBoxes(this); // Clear text boxes after updating user
                LoadData();  // Refresh the data in DataGridView
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred while updating the user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e) // Delete button
        {
            // Ensure a row is selected
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.No)
                {
                    return; // Exit if user chooses not to delete
                }

                string sql = "DELETE FROM [User] WHERE UserID=@UserID";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@UserID", dataGridView1.SelectedRows[0].Cells["UserID"].Value); // Assuming UserID is the primary key
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearTextBoxes(this); // Clear text boxes after deleting user
                LoadData();  // Refresh the data in DataGridView
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
