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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ListBox_Month.SetSelected(0, true);
            ListBox_Year.SetSelected(0, true);
        }

        //Getting today's total
        private void btn_get_total_Click(object sender, EventArgs e)
        {
            var now = DateTime.Now.Date;

            //Connecting to the database
            try
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=DESKTOP-IFD9SVP;Initial Catalog=RapidRhythms;Integrated Security=SSPI";
                cnn = new SqlConnection(connetionString);
                cnn.Open();

                SqlCommand command;
                SqlDataReader dataReader;
                String sql, Output = "";

                sql = "select count(*) Total_attendance, sum(case when a.Purchase_type = 'class' or a.Purchase_type = 'used month pass for class' or a.Purchase_type = 'class and dance' or a.Purchase_type = 'used month pass for class and dance' then 1 else 0 end) Total_class_attendance, sum(case when a.Purchase_type = 'dance' or a.Purchase_type = 'used month pass for dance' or a.Purchase_type = 'class and dance' or a.Purchase_type = 'used month pass for class and dance' then 1 else 0 end) Total_dance_attendance, '$' + cast(sum(a.Payment_amount) as VARCHAR(20)) Total_revenue, sum(case when a.Purchase_type = 'used month pass for class and dance' then - 1 else 0 end) Guard_against_counting_month_pass_twice, sum(case when a.Purchase_type = 'class and dance' then - 1 else 0 end) Guard_against_counting_twice from Attendance a where a.Transaction_date = '" + now + "';";
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Output = Output + "\nOverall attendance: " + dataReader.GetValue(0) + "\nClass attendance: " + dataReader.GetValue(1) + "\nDance attendance:  " + dataReader.GetValue(2) + "\nRevenue: " + dataReader.GetValue(3) + "\n";
                }

                MessageBox.Show(Output);
                cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Getting monthly totals
        private void button1_Click(object sender, EventArgs e)
        {
            string listBox_Year_Value = ListBox_Year.GetItemText(ListBox_Year.SelectedItem);
            string listBox_Month_Value = ListBox_Month.GetItemText(ListBox_Month.SelectedItem);
            string month = "";
            string string_year_and_month;
            int int_year_and_month;

            //Creating the classID from the selected listbox item
            switch (listBox_Month_Value)
            {
                case "January":
                    month = "01";
                    break;
                case "February":
                    month = "02";
                    break;
                case "March":
                    month = "03";
                    break;
                case "April":
                    month = "04";
                    break;
                case "May":
                    month = "05";
                    break;
                case "June":
                    month = "06";
                    break;
                case "July":
                    month = "07";
                    break;
                case "August":
                    month = "08";
                    break;
                case "September":
                    month = "09";
                    break;
                case "October":
                    month = "10";
                    break;
                case "November":
                    month = "11";
                    break;
                case "December":
                    month = "12";
                    break;
            }
            string_year_and_month = listBox_Year_Value + month;
            int_year_and_month = Int32.Parse(string_year_and_month);

            //Connecting to the database
            try
            {
                //First query - getting instructor and class names
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=DESKTOP-IFD9SVP;Initial Catalog=RapidRhythms;Integrated Security=SSPI";
                cnn = new SqlConnection(connetionString);
                cnn.Open();

                SqlCommand command;
                SqlDataReader dataReader;
                String sql, InstructorOutput = "";

                sql = "select c.Class_name, i.Instructor_fname, (select i.Instructor_fname from class c, instructor i where c.Instructor_Two_id = i.Instructor_id and c.class_id = " + int_year_and_month + ") Instructor_Two_Fname from class c, instructor i where c.Instructor_id = i.Instructor_id and c.class_id = " + int_year_and_month + ";";
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    InstructorOutput = InstructorOutput + "\n" + listBox_Month_Value + " " + listBox_Year_Value + "'s class '" + dataReader.GetValue(0) + "' was taught by " + dataReader.GetValue(1) + "\nand " + dataReader.GetValue(2) + ".\n";
                }

                cnn.Close();

                //Second Query - getting monthly attendance totals
                string connetionStringTwo;
                SqlConnection cnnTwo;
                connetionStringTwo = @"Data Source=DESKTOP-IFD9SVP;Initial Catalog=RapidRhythms;Integrated Security=SSPI";
                cnnTwo = new SqlConnection(connetionStringTwo);
                cnnTwo.Open();

                SqlCommand commandTwo;
                SqlDataReader dataReaderTwo;
                String sqlTwo, AttendanceOutput = "";

                sqlTwo = "select count(*) Total_attendance, sum(case when a.Purchase_type = 'class' or a.Purchase_type = 'used month pass for class' or a.Purchase_type = 'class and dance' or a.Purchase_type = 'used month pass for class and dance' then 1 else 0 end) Total_class_attendance, sum(case when a.Purchase_type = 'dance' or a.Purchase_type = 'used month pass for dance' or a.Purchase_type = 'class and dance' or a.Purchase_type = 'used month pass for class and dance' then 1 else 0 end) Total_dance_attendance, '$' + cast(sum(a.Payment_amount) as VARCHAR(20)) Total_revenue, sum(case when a.Purchase_type = 'used month pass for class and dance' then - 1 else 0 end) Guard_against_counting_month_pass_twice, sum(case when a.Purchase_type = 'class and dance' then - 1 else 0 end) Guard_against_counting_twice from Attendance a where a.class_id = " + int_year_and_month + ";";
                commandTwo = new SqlCommand(sqlTwo, cnnTwo);
                dataReaderTwo = commandTwo.ExecuteReader();

                while (dataReaderTwo.Read())
                {
                    AttendanceOutput = AttendanceOutput + "\nOverall attendance: " + dataReaderTwo.GetValue(0) + "\nClass attendance: " + dataReaderTwo.GetValue(1) + "\nDance attendance:  " + dataReaderTwo.GetValue(2) + "\nRevenue for the month: " + dataReaderTwo.GetValue(3) + "\n";
                }

                cnnTwo.Close();

                //Third query - getting all notes for the month
                string connetionStringThree;
                SqlConnection cnnThree;
                connetionStringThree = @"Data Source=DESKTOP-IFD9SVP;Initial Catalog=RapidRhythms;Integrated Security=SSPI";
                cnnThree = new SqlConnection(connetionStringThree);
                cnnThree.Open();

                SqlCommand commandThree;
                SqlDataReader dataReaderThree;
                String sqlThree, notes_Output = "";

                sqlThree = "select Note, create_date from Notes where class_id = " + int_year_and_month + ";";
                commandThree = new SqlCommand(sqlThree, cnnThree);
                dataReaderThree = commandThree.ExecuteReader();

                while (dataReaderThree.Read())
                {
                    string note_date;
                    note_date = dataReaderThree.GetValue(1).ToString().Remove(8);
                    notes_Output = notes_Output + "\n The note reading '" + dataReaderThree.GetValue(0) + "' was created on " + note_date + ".\n";
                }

                MessageBox.Show(InstructorOutput + AttendanceOutput + notes_Output);
                cnnTwo.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}   
