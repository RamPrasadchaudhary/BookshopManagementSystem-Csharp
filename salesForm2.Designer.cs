namespace Book_Shop_Management_System
{
    partial class salesForm2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.searchtextbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(383, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(356, 46);
            this.label8.TabIndex = 26;
            this.label8.Text = "Sale  Book Record";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(192, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(830, 423);
            this.dataGridView1.TabIndex = 45;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.buttonsearch);
            this.groupBox1.Controls.Add(this.searchtextbox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(87, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1020, 105);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // buttonsearch
            // 
            this.buttonsearch.Location = new System.Drawing.Point(368, 72);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(111, 27);
            this.buttonsearch.TabIndex = 38;
            this.buttonsearch.Text = "Search";
            this.buttonsearch.UseVisualStyleBackColor = true;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // searchtextbox
            // 
            this.searchtextbox.Location = new System.Drawing.Point(448, 21);
            this.searchtextbox.Multiline = true;
            this.searchtextbox.Name = "searchtextbox";
            this.searchtextbox.Size = new System.Drawing.Size(227, 32);
            this.searchtextbox.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Purple;
            this.label10.Location = new System.Drawing.Point(202, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(222, 30);
            this.label10.TabIndex = 36;
            this.label10.Text = "Enter the  Book or ID";
            // 
            // salesForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 726);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "salesForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "salesForm2";
            this.Load += new System.EventHandler(this.salesForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox searchtextbox;
        private System.Windows.Forms.Button buttonsearch;
    }
}