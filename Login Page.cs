using Final_Project.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {
            Registration_Form registration_Form = new Registration_Form();
            registration_Form.Show();
            this.Hide();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (ValidateUser(TextBox1.Text, TextBox2.Text))
            {
                Home_Page home_Page = new Home_Page();
                this.Hide();
                home_Page.ShowDialog();
                this.Dispose();
            }
            else
            {
                DialogResult result = MessageBox.Show("Invalid username or password. Try Again", "Login", MessageBoxButtons.OK);
            }
        }
        public static bool ValidateUser(string username, string password)
        {
            using (var context = new ECommerceContext())
            {
                
                var user = context.Users
                    .FirstOrDefault(u => u.UserName == username);

                if (user != null)
                {
                    
                    return user.Password == password;
                }

                return false; 
            }
        }
    }
}
