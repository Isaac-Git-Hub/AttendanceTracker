using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Tracker
{
    public partial class Form1 : Form
    {
        string purchase_selection;
        string payment_method;
        int payment_amount;
        DateTime currentDate;
        int int_current_month;
        string string_current_month;
        string current_year;
        string string_class_id;
        int int_class_id;
   
        public Form1()
        {
            InitializeComponent();
        }

        //Clicking the "Submit" button:
        private void btn_submit_Click(object sender, EventArgs e)
        {
            // Getting value for Type of purchase groupbox
            if (purchase_class.Checked)
            {
                purchase_selection = "class";
                payment_amount = 6;
            }
            if (purchase_dance.Checked)
            {
                purchase_selection = "dance";
                payment_amount = 6;
            }
            if (purchase_class_and_dance.Checked)
            {
                purchase_selection = "class and dance";
                payment_amount = 10;
            }
            if (month_pass_class.Checked)
            {
                purchase_selection = "used month pass for class";
                if (CheckBoxMonthPass.Checked)
                {
                    payment_amount = 30;
                }
                else
                {
                    payment_amount = 0;
                }
            }
            if (month_pass_dance.Checked)
            {
                purchase_selection = "used month pass for dance";
                if (CheckBoxMonthPass.Checked)
                {
                    payment_amount = 30;
                }
                else
                {
                    payment_amount = 0;
                }
            }
            if (month_pass_class_and_dance.Checked)
            {
                purchase_selection = "used month pass for class and dance";
                if (CheckBoxMonthPass.Checked)
                {
                    payment_amount = 30;
                }
                else
                {
                    payment_amount = 0;
                }
            }

            //Getting value for Payment method groupbox
            if (payment_cash.Checked)
            {
                payment_method = "cash";
            }
            if (payment_card.Checked)
            {
                payment_method = "card";
            }
            if (payment_check.Checked)
            {
                payment_method = "check";
            }
            if (payment_free.Checked)
            {
                payment_method = "free night";
                payment_amount = 0;
            }

            //Creating the class_id
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

            //Getting current datetime
            currentDate = DateTime.Now.Date;

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

                sql = "insert into Attendance (Purchase_type, Payment_method, Payment_amount, Class_id, Transaction_Date) VALUES('" + purchase_selection + "','" + payment_method + "'," + payment_amount + "," + int_class_id + ", '" + currentDate + "' );";
                command = new SqlCommand(sql, cnn);

                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Transaction successfully submitted.");
                cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            CheckBoxMonthPass.Checked = false;
        }

        //Opens the stats form
        private void btn_get_total_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        //Opens the notes form
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}
