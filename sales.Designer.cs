namespace Book_Shop_Management_System
{
    partial class sales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.custemailtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.custnametxt = new System.Windows.Forms.TextBox();
            this.custphonetxt = new System.Windows.Forms.TextBox();
            this.custaddresstxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.proceed = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bookIdtxt = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Booknametxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.quantitytxt = new System.Windows.Forms.NumericUpDown();
            this.genretxt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.amounttxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantitytxt)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(468, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 36);
            this.label8.TabIndex = 20;
            this.label8.Text = "Sale  Book";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.custemailtxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.custnametxt);
            this.groupBox1.Controls.Add(this.custphonetxt);
            this.groupBox1.Controls.Add(this.custaddresstxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 283);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // custemailtxt
            // 
            this.custemailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custemailtxt.Location = new System.Drawing.Point(202, 146);
            this.custemailtxt.Multiline = true;
            this.custemailtxt.Name = "custemailtxt";
            this.custemailtxt.Size = new System.Drawing.Size(248, 30);
            this.custemailtxt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(6, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // custnametxt
            // 
            this.custnametxt.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custnametxt.Location = new System.Drawing.Point(202, 21);
            this.custnametxt.Multiline = true;
            this.custnametxt.Name = "custnametxt";
            this.custnametxt.Size = new System.Drawing.Size(248, 30);
            this.custnametxt.TabIndex = 5;
            this.custnametxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // custphonetxt
            // 
            this.custphonetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custphonetxt.Location = new System.Drawing.Point(202, 208);
            this.custphonetxt.Multiline = true;
            this.custphonetxt.Name = "custphonetxt";
            this.custphonetxt.Size = new System.Drawing.Size(248, 30);
            this.custphonetxt.TabIndex = 10;
            // 
            // custaddresstxt
            // 
            this.custaddresstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custaddresstxt.Location = new System.Drawing.Point(202, 88);
            this.custaddresstxt.Multiline = true;
            this.custaddresstxt.Name = "custaddresstxt";
            this.custaddresstxt.Size = new System.Drawing.Size(248, 30);
            this.custaddresstxt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(6, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone";
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.Purple;
            this.cancel.Location = new System.Drawing.Point(596, 378);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(109, 47);
            this.cancel.TabIndex = 16;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // proceed
            // 
            this.proceed.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceed.ForeColor = System.Drawing.Color.Purple;
            this.proceed.Location = new System.Drawing.Point(283, 378);
            this.proceed.Name = "proceed";
            this.proceed.Size = new System.Drawing.Size(109, 47);
            this.proceed.TabIndex = 0;
            this.proceed.Text = "Proceed";
            this.proceed.UseVisualStyleBackColor = true;
            this.proceed.Click += new System.EventHandler(this.proceed_Click);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.Color.Purple;
            this.reset.Location = new System.Drawing.Point(443, 378);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(109, 47);
            this.reset.TabIndex = 15;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.bookIdtxt);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.Booknametxt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.quantitytxt);
            this.groupBox2.Controls.Add(this.genretxt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.amounttxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(575, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 289);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book Details";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Purple;
            this.label10.Location = new System.Drawing.Point(8, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 30);
            this.label10.TabIndex = 30;
            this.label10.Text = "Book ID:";
            // 
            // bookIdtxt
            // 
            this.bookIdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIdtxt.Location = new System.Drawing.Point(166, 33);
            this.bookIdtxt.Multiline = true;
            this.bookIdtxt.Name = "bookIdtxt";
            this.bookIdtxt.Size = new System.Drawing.Size(248, 30);
            this.bookIdtxt.TabIndex = 29;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Purple;
            this.button4.Location = new System.Drawing.Point(185, 241);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 47);
            this.button4.TabIndex = 29;
            this.button4.Text = "Add Book";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Booknametxt
            // 
            this.Booknametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booknametxt.Location = new System.Drawing.Point(166, 77);
            this.Booknametxt.Multiline = true;
            this.Booknametxt.Name = "Booknametxt";
            this.Booknametxt.Size = new System.Drawing.Size(248, 30);
            this.Booknametxt.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(8, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 30);
            this.label9.TabIndex = 27;
            this.label9.Text = "Book Name";
            // 
            // quantitytxt
            // 
            this.quantitytxt.Location = new System.Drawing.Point(166, 121);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(248, 27);
            this.quantitytxt.TabIndex = 26;
            // 
            // genretxt
            // 
            this.genretxt.FormattingEnabled = true;
            this.genretxt.Items.AddRange(new object[] {
            "Commerce",
            "Education",
            "Art",
            "Engineering",
            "Science",
            "Literature",
            "History",
            "Guide",
            "Medical",
            "others"});
            this.genretxt.Location = new System.Drawing.Point(166, 165);
            this.genretxt.Name = "genretxt";
            this.genretxt.Size = new System.Drawing.Size(248, 28);
            this.genretxt.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(8, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 30);
            this.label7.TabIndex = 24;
            this.label7.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(8, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 30);
            this.label3.TabIndex = 21;
            this.label3.Text = "Genre";
            // 
            // amounttxt
            // 
            this.amounttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amounttxt.Location = new System.Drawing.Point(166, 205);
            this.amounttxt.Multiline = true;
            this.amounttxt.Name = "amounttxt";
            this.amounttxt.Size = new System.Drawing.Size(248, 30);
            this.amounttxt.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(7, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 30);
            this.label6.TabIndex = 22;
            this.label6.Text = "Amount per";
            // 
            // cartListBox
            // 
            this.cartListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.ItemHeight = 16;
            this.cartListBox.Location = new System.Drawing.Point(164, 431);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(747, 196);
            this.cartListBox.TabIndex = 22;
            this.cartListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 643);
            this.Controls.Add(this.cartListBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.proceed);
            this.Controls.Add(this.cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sales";
            this.Text = "sales";
            this.Load += new System.EventHandler(this.sales_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantitytxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox custemailtxt;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button proceed;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox custnametxt;
        private System.Windows.Forms.TextBox custphonetxt;
        private System.Windows.Forms.TextBox custaddresstxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox Booknametxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown quantitytxt;
        private System.Windows.Forms.ComboBox genretxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amounttxt;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.TextBox bookIdtxt;
        private System.Windows.Forms.Label label10;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}