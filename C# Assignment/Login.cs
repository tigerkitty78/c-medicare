using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace C__Assignment
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string PatientID = textBox1.Text;
            string Password = textBox2.Text;

            if (PatientID == "" && Password == "")
            {
                MessageBox.Show("Incorrect UserName and/or Password");
            }
            else
            {
                Home objHome = new Home();
                objHome.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FPassword objPass = new FPassword();
            objPass.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Signup objSign = new Signup();
            objSign.Show();
            this.Hide();
        }
    }
}
