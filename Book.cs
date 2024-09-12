using System;
using System.Drawing;
using System.Windows.Forms;
namespace Book_Shop_Management_System
{
    public partial class Book : Form
    {
        private string username;
        public Book(string username)
        {
            InitializeComponent();
            this.username = username;
            this.Load += Book_Load; // Ensure the Load event is connected
        }
        private void Book_Load(object sender, EventArgs e)
        {
            if(label4 != null)
            {
                label4.Text = $"Welcome, {username.ToUpper()}!";
            }
            else
            {
                MessageBox.Show("label4 is not found.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenFormInPanel(Form form)
        {
            panel1.Controls.Clear();
            form.TopLevel = false;
            int x = (panel1.Width - form.Width) / 2;
            int y = (panel1.Height - form.Height) / 2;
            form.Location = new Point(x, y);
            form.FormClosed += (s, args) => panel1.Controls.Remove(form);
            panel1.Controls.Add(form);
            form.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Add_Book());
        }
        private void button6_Click(object sender, EventArgs e)
        {
            loginform loginform = new loginform();
            loginform.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new customer());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Book_Record());
        }
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new salesForm2());
        }
        private void button9_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new user());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new sales());
        }
        private void button7_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new DashBoard());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
