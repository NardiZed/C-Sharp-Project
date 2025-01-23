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

namespace Final_Project
{
    public partial class Registration_Form : Form
    {
        public Registration_Form()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            registrationClass user;
            SqlConnection conn = new SqlConnection("Data Source=Nardos-Zerihun;Initial Catalog=FinalProject;Integrated Security=True;Trust Server Certificate=True");
            using (conn)
            {
                conn.Open();
                string query = "Insert into Users values (@Name,@Email,@Password)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@Email", TextBox2.Text);
                cmd.Parameters.AddWithValue("@Password", TextBox3.Text);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data inserted successfully.");
                }
                else
                {
                    MessageBox.Show("Data insertion failed.");
                }
            }
        }
    }
}
