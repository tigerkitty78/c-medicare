using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlClient;
using System.Net;
using System.Net.NetworkInformation;

namespace C__Assignment
{
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int AppID = Convert.ToInt32(textBox1.Text);
            int PatientID = Convert.ToInt32(textBox2.Text);
            int DoctorID = Convert.ToInt32(textBox3.Text);
            string Date = textBox4.Text;
            string Time = textBox5.Text;

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\MedicareDB.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "Insert into Booking values('" + AppID + "','" + PatientID + "','" + DoctorID + "','" + Date + "','" + Time + "')";
            SqlCommand cmd = new SqlCommand(qry, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Appointment sucessfully booked!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home objHome = new Home();
            objHome.Show();
            this.Hide();
        }
    }
}
