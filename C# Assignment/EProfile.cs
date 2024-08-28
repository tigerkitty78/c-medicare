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
    public partial class EProfile : Form
    {
        public EProfile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FullName = textBox1.Text;
            int ContactNo = int.Parse(textBox2.Text);
            string DOB = textBox4.Text;
            string Email = textBox3.Text;
            string Address = textBox5.Text;
            int PatientID = int.Parse(textBox6.Text);
            string Password = textBox7.Text;

            textBox7.PasswordChar = '*';

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\MedicareDB.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "UPDATE SET FullName = '" + FullName + "',ContactNo = '" + ContactNo + "',DOB = '" + DOB + "',Email = '" + Email + "',Address = '" + Address + "',Password = '" + Password + "' WHERE PatientID = '" + PatientID + "'";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            string FullName = textBox1.Text;
            int ContactNo = int.Parse(textBox2.Text);
            string DOB = textBox4.Text;
            string Email = textBox3.Text;
            string Address = textBox5.Text;
            int PatientID = int.Parse(textBox6.Text);
            string Password = textBox7.Text;

            textBox7.PasswordChar = '*';
            textBox7.CharacterCasing = CharacterCasing.Upper;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\MedicareDB.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "INSERT INTO VALUES('" + FullName + "','" + ContactNo + "','" + DOB + "','" + Email + "','" + Address + "','" + Password + "')";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data entered successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Profile objPro = new Profile();
            objPro.Show();
            this.Hide();
        }
    }
}
