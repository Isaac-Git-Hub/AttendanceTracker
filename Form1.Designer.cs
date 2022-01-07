
namespace Attendance_Tracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.grp_box_purchase = new System.Windows.Forms.GroupBox();
            this.month_pass_class_and_dance = new System.Windows.Forms.RadioButton();
            this.month_pass_dance = new System.Windows.Forms.RadioButton();
            this.month_pass_class = new System.Windows.Forms.RadioButton();
            this.purchase_class_and_dance = new System.Windows.Forms.RadioButton();
            this.purchase_dance = new System.Windows.Forms.RadioButton();
            this.purchase_class = new System.Windows.Forms.RadioButton();
            this.grp_box_pymt_mthd = new System.Windows.Forms.GroupBox();
            this.payment_free = new System.Windows.Forms.RadioButton();
            this.payment_check = new System.Windows.Forms.RadioButton();
            this.payment_card = new System.Windows.Forms.RadioButton();
            this.payment_cash = new System.Windows.Forms.RadioButton();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_get_total = new System.Windows.Forms.Button();
            this.CheckBoxMonthPass = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grp_box_purchase.SuspendLayout();
            this.grp_box_pymt_mthd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // grp_box_purchase
            // 
            this.grp_box_purchase.Controls.Add(this.month_pass_class_and_dance);
            this.grp_box_purchase.Controls.Add(this.month_pass_dance);
            this.grp_box_purchase.Controls.Add(this.month_pass_class);
            this.grp_box_purchase.Controls.Add(this.purchase_class_and_dance);
            this.grp_box_purchase.Controls.Add(this.purchase_dance);
            this.grp_box_purchase.Controls.Add(this.purchase_class);
            this.grp_box_purchase.Location = new System.Drawing.Point(12, 12);
            this.grp_box_purchase.Name = "grp_box_purchase";
            this.grp_box_purchase.Size = new System.Drawing.Size(267, 181);
            this.grp_box_purchase.TabIndex = 1;
            this.grp_box_purchase.TabStop = false;
            this.grp_box_purchase.Text = "Type of purchase:";
            // 
            // month_pass_class_and_dance
            // 
            this.month_pass_class_and_dance.AutoSize = true;
            this.month_pass_class_and_dance.Location = new System.Drawing.Point(7, 149);
            this.month_pass_class_and_dance.Name = "month_pass_class_and_dance";
            this.month_pass_class_and_dance.Size = new System.Drawing.Size(220, 19);
            this.month_pass_class_and_dance.TabIndex = 5;
            this.month_pass_class_and_dance.TabStop = true;
            this.month_pass_class_and_dance.Text = "Used month pass for class and dance";
            this.month_pass_class_and_dance.UseVisualStyleBackColor = true;
            // 
            // month_pass_dance
            // 
            this.month_pass_dance.AutoSize = true;
            this.month_pass_dance.Location = new System.Drawing.Point(7, 123);
            this.month_pass_dance.Name = "month_pass_dance";
            this.month_pass_dance.Size = new System.Drawing.Size(169, 19);
            this.month_pass_dance.TabIndex = 4;
            this.month_pass_dance.Text = "Used month pass for dance";
            this.month_pass_dance.UseVisualStyleBackColor = true;
            // 
            // month_pass_class
            // 
            this.month_pass_class.AutoSize = true;
            this.month_pass_class.Location = new System.Drawing.Point(7, 98);
            this.month_pass_class.Name = "month_pass_class";
            this.month_pass_class.Size = new System.Drawing.Size(162, 19);
            this.month_pass_class.TabIndex = 3;
            this.month_pass_class.Text = "Used month pass for class";
            this.month_pass_class.UseVisualStyleBackColor = true;
            // 
            // purchase_class_and_dance
            // 
            this.purchase_class_and_dance.AutoSize = true;
            this.purchase_class_and_dance.Location = new System.Drawing.Point(7, 73);
            this.purchase_class_and_dance.Name = "purchase_class_and_dance";
            this.purchase_class_and_dance.Size = new System.Drawing.Size(110, 19);
            this.purchase_class_and_dance.TabIndex = 2;
            this.purchase_class_and_dance.Text = "Class and dance";
            this.purchase_class_and_dance.UseVisualStyleBackColor = true;
            // 
            // purchase_dance
            // 
            this.purchase_dance.AutoSize = true;
            this.purchase_dance.Location = new System.Drawing.Point(7, 48);
            this.purchase_dance.Name = "purchase_dance";
            this.purchase_dance.Size = new System.Drawing.Size(58, 19);
            this.purchase_dance.TabIndex = 1;
            this.purchase_dance.Text = "Dance";
            this.purchase_dance.UseVisualStyleBackColor = true;
            // 
            // purchase_class
            // 
            this.purchase_class.AutoSize = true;
            this.purchase_class.Checked = true;
            this.purchase_class.Location = new System.Drawing.Point(7, 23);
            this.purchase_class.Name = "purchase_class";
            this.purchase_class.Size = new System.Drawing.Size(52, 19);
            this.purchase_class.TabIndex = 0;
            this.purchase_class.TabStop = true;
            this.purchase_class.Text = "Class";
            this.purchase_class.UseVisualStyleBackColor = true;
            // 
            // grp_box_pymt_mthd
            // 
            this.grp_box_pymt_mthd.Controls.Add(this.payment_free);
            this.grp_box_pymt_mthd.Controls.Add(this.payment_check);
            this.grp_box_pymt_mthd.Controls.Add(this.payment_card);
            this.grp_box_pymt_mthd.Controls.Add(this.payment_cash);
            this.grp_box_pymt_mthd.Location = new System.Drawing.Point(12, 199);
            this.grp_box_pymt_mthd.Name = "grp_box_pymt_mthd";
            this.grp_box_pymt_mthd.Size = new System.Drawing.Size(267, 127);
            this.grp_box_pymt_mthd.TabIndex = 5;
            this.grp_box_pymt_mthd.TabStop = false;
            this.grp_box_pymt_mthd.Text = "Method of payment:";
            // 
            // payment_free
            // 
            this.payment_free.AutoSize = true;
            this.payment_free.Location = new System.Drawing.Point(7, 98);
            this.payment_free.Name = "payment_free";
            this.payment_free.Size = new System.Drawing.Size(78, 19);
            this.payment_free.TabIndex = 3;
            this.payment_free.Text = "Free night";
            this.payment_free.UseVisualStyleBackColor = true;
            // 
            // payment_check
            // 
            this.payment_check.AutoSize = true;
            this.payment_check.Location = new System.Drawing.Point(7, 73);
            this.payment_check.Name = "payment_check";
            this.payment_check.Size = new System.Drawing.Size(58, 19);
            this.payment_check.TabIndex = 2;
            this.payment_check.Text = "Check";
            this.payment_check.UseVisualStyleBackColor = true;
            // 
            // payment_card
            // 
            this.payment_card.AutoSize = true;
            this.payment_card.Location = new System.Drawing.Point(7, 48);
            this.payment_card.Name = "payment_card";
            this.payment_card.Size = new System.Drawing.Size(50, 19);
            this.payment_card.TabIndex = 1;
            this.payment_card.Text = "Card";
            this.payment_card.UseVisualStyleBackColor = true;
            // 
            // payment_cash
            // 
            this.payment_cash.AutoSize = true;
            this.payment_cash.Checked = true;
            this.payment_cash.Location = new System.Drawing.Point(7, 23);
            this.payment_cash.Name = "payment_cash";
            this.payment_cash.Size = new System.Drawing.Size(51, 19);
            this.payment_cash.TabIndex = 0;
            this.payment_cash.TabStop = true;
            this.payment_cash.Text = "Cash";
            this.payment_cash.UseVisualStyleBackColor = true;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_submit.Location = new System.Drawing.Point(11, 396);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(118, 32);
            this.btn_submit.TabIndex = 6;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_get_total
            // 
            this.btn_get_total.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_get_total.Location = new System.Drawing.Point(293, 396);
            this.btn_get_total.Name = "btn_get_total";
            this.btn_get_total.Size = new System.Drawing.Size(118, 32);
            this.btn_get_total.TabIndex = 7;
            this.btn_get_total.Text = "View stats";
            this.btn_get_total.UseVisualStyleBackColor = false;
            this.btn_get_total.Click += new System.EventHandler(this.btn_get_total_Click);
            // 
            // CheckBoxMonthPass
            // 
            this.CheckBoxMonthPass.AutoSize = true;
            this.CheckBoxMonthPass.Location = new System.Drawing.Point(12, 352);
            this.CheckBoxMonthPass.Name = "CheckBoxMonthPass";
            this.CheckBoxMonthPass.Size = new System.Drawing.Size(257, 19);
            this.CheckBoxMonthPass.TabIndex = 8;
            this.CheckBoxMonthPass.Text = "Check if person bought month pass tonight";
            this.CheckBoxMonthPass.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(151, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Write note";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(322, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(598, 440);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CheckBoxMonthPass);
            this.Controls.Add(this.btn_get_total);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.grp_box_pymt_mthd);
            this.Controls.Add(this.grp_box_purchase);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(311, 410);
            this.Name = "Form1";
            this.Text = "AttendanceTracker";
            this.grp_box_purchase.ResumeLayout(false);
            this.grp_box_purchase.PerformLayout();
            this.grp_box_pymt_mthd.ResumeLayout(false);
            this.grp_box_pymt_mthd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_box_purchase;
        private System.Windows.Forms.RadioButton month_pass_dance;
        private System.Windows.Forms.RadioButton month_pass_class;
        private System.Windows.Forms.RadioButton purchase_class_and_dance;
        private System.Windows.Forms.RadioButton purchase_dance;
        private System.Windows.Forms.RadioButton purchase_class;
        private System.Windows.Forms.GroupBox grp_box_pymt_mthd;
        private System.Windows.Forms.RadioButton payment_check;
        private System.Windows.Forms.RadioButton payment_card;
        private System.Windows.Forms.RadioButton payment_cash;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.RadioButton payment_free;
        private System.Windows.Forms.Button btn_get_total;
        private System.Windows.Forms.RadioButton month_pass_class_and_dance;
        private System.Windows.Forms.CheckBox CheckBoxMonthPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

