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

namespace C__Assignment
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FullName = textBox1.Text;
            int ContactNo = int.Parse(textBox2.Text);
            string Email = textBox3.Text;
            string DOB = textBox4.Text;
            string Address = textBox5.Text;
            int PatientID = int.Parse(textBox6.Text);
            string Password = textBox7.Text;

            textBox7.PasswordChar = '*';

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\MedicareDB.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = @"INSERT into Signup values('" + FullName + "','" + ContactNo + "','" + Email + "','" + DOB + "','" + Address + "',@PatientID,'" + Password + "')";
            SqlParameter patientIDParam = new SqlParameter("@PatientID", PatientID);

            SqlCommand cmd = new SqlCommand(qry, conn);
            cmd.Parameters.Add(patientIDParam);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Sucessfully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            Login objLog = new Login();
            objLog.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login objLog = new Login();
            objLog.Show();
            this.Hide();
        }
    }
}
signup