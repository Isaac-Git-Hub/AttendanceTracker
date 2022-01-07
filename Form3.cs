using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Attendance_Tracker
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button_Submit_Note_Click(object sender, EventArgs e)
        {
            //Creating the class id
            int int_current_month;
            string string_current_month;
            string current_year;
            string string_class_id;
            int int_class_id;
            string textbox_text = textbox_Notes.Text;
            DateTime current_date = DateTime.Now.Date;

            int_current_month = DateTime.Now.Month;
            if (int_current_month < 10)
            {
                string_current_month = int_current_month.ToString();
                string_current_month = "0" + string_current_month;
            }
            else
            {
                string_current_month = int_current_month.ToString();
            }
            current_year = DateTime.Now.Year.ToString();
            string_class_id = current_year + string_current_month;
            int_class_id = Int32.Parse(string_class_id);

            //Connecting to the database
            try
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=DESKTOP-IFD9SVP;Initial Catalog=RapidRhythms;Integrated Security=SSPI";
                cnn = new SqlConnection(connetionString);
                cnn.Open();

                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql = "";

                sql = "insert into Notes (Note, Class_id, Create_date) VALUES('" + textbox_text + "'," + int_class_id + ",'" + current_date + "');";
                command = new SqlCommand(sql, cnn);

                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Note successfully submitted.");
                cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }
    }
}