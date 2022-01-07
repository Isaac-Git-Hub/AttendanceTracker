
namespace Attendance_Tracker
{
    partial class Form2
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
            this.btn_get_total = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ListBox_Month = new System.Windows.Forms.ListBox();
            this.ListBox_Year = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_get_total
            // 
            this.btn_get_total.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_get_total.Location = new System.Drawing.Point(12, 22);
            this.btn_get_total.Name = "btn_get_total";
            this.btn_get_total.Size = new System.Drawing.Size(92, 32);
            this.btn_get_total.TabIndex = 8;
            this.btn_get_total.Text = "View totals";
            this.btn_get_total.UseVisualStyleBackColor = false;
            this.btn_get_total.Click += new System.EventHandler(this.btn_get_total_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_get_total);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 68);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Today\'s total";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ListBox_Month);
            this.groupBox2.Controls.Add(this.ListBox_Year);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(119, 285);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Monthly totals";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select month:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select year:";
            // 
            // ListBox_Month
            // 
            this.ListBox_Month.FormattingEnabled = true;
            this.ListBox_Month.ItemHeight = 15;
            this.ListBox_Month.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.ListBox_Month.Location = new System.Drawing.Point(12, 147);
            this.ListBox_Month.Name = "ListBox_Month";
            this.ListBox_Month.Size = new System.Drawing.Size(92, 64);
            this.ListBox_Month.TabIndex = 2;
            // 
            // ListBox_Year
            // 
            this.ListBox_Year.FormattingEnabled = true;
            this.ListBox_Year.ItemHeight = 15;
            this.ListBox_Year.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.ListBox_Year.Location = new System.Drawing.Point(12, 48);
            this.ListBox_Year.Name = "ListBox_Year";
            this.ListBox_Year.Size = new System.Drawing.Size(92, 64);
            this.ListBox_Year.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(12, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "View totals";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(194, 401);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "View Totals";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_get_total;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListBox_Month;
        private System.Windows.Forms.ListBox ListBox_Year;
        private System.Windows.Forms.Button button1;
    }
}