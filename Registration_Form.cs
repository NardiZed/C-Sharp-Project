using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Final_Project.Models;
using Final_Project.Data;

namespace Final_Project
{
    public partial class Registration_Form : Form
    {
        string str;
        public Registration_Form()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                str = "Customer";
            }
            else
            {
                str = "Administrator";
            }

            var newUser = new Users
            {
                FullName = TextBox1.Text,
                Email = TextBox2.Text,
                UserName = TextBox3.Text,
                Password = TextBox4.Text,
                Role = str
            };

            using (var context = new ECommerceContext())
            {
                context.Users.Add(newUser);
                context.SaveChanges();
            }

            DialogResult result = MessageBox.Show("Registered Successfully. Login with your Credentials", "Registration", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                Form1 lp = new Form1(); 
                lp.ShowDialog();
                this.Hide();
                this.Close();
            }
            
        }
    }
}
