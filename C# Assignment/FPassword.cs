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
    public partial class FPassword : Form
    {
        public FPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int PatientID = int.Parse(textBox1.Text);
            string Password = textBox2.Text;

            textBox2.PasswordChar = '*';
            textBox2.CharacterCasing = CharacterCasing.Lower;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\MedicareDB.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "UPDATE Edit SET Password = '" + Password + "' WHERE PatientID = '" + PatientID + "'";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Password updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login objLog = new Login();
            objLog.Show();
            this.Hide();
        }
    }
}
