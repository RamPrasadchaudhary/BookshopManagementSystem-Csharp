using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Shop_Management_System
{
    public partial class spalash : Form
    {
        public spalash()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        int startposition = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startposition += 1;
            myprogress.Value = startposition;
            percentlabel.Text = $"{startposition}%";

            if (myprogress.Value == 100)
            {
                myprogress.Value = 0;
                timer1.Stop();
                loginform form = new loginform();
                form.Show(); // Show the Book form
                this.Hide();
            }
        }

        private void spalash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void myprogress_Click(object sender, EventArgs e)
        {

        }
    }
}