
namespace Attendance_Tracker
{
    partial class Form3
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
            this.textbox_Notes = new System.Windows.Forms.TextBox();
            this.button_Submit_Note = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textbox_Notes
            // 
            this.textbox_Notes.Location = new System.Drawing.Point(32, 27);
            this.textbox_Notes.Multiline = true;
            this.textbox_Notes.Name = "textbox_Notes";
            this.textbox_Notes.Size = new System.Drawing.Size(321, 171);
            this.textbox_Notes.TabIndex = 0;
            // 
            // button_Submit_Note
            // 
            this.button_Submit_Note.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Submit_Note.Location = new System.Drawing.Point(147, 214);
            this.button_Submit_Note.Name = "button_Submit_Note";
            this.button_Submit_Note.Size = new System.Drawing.Size(95, 30);
            this.button_Submit_Note.TabIndex = 1;
            this.button_Submit_Note.Text = "Submit";
            this.button_Submit_Note.UseVisualStyleBackColor = false;
            this.button_Submit_Note.Click += new System.EventHandler(this.button_Submit_Note_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(388, 256);
            this.Controls.Add(this.button_Submit_Note);
            this.Controls.Add(this.textbox_Notes);
            this.Name = "Form3";
            this.Text = "Write note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_Notes;
        private System.Windows.Forms.Button button_Submit_Note;
    }
}