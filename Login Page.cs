using Microsoft.Data.SqlClient;

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
            SqlConnection conn = new SqlConnection("Data Source=Nardos-Zerihun;Initial Catalog=FinalProject;Integrated Security=True;Trust Server Certificate=True");
            using (conn)
            {
                string query = "SELECT UserID FROM registeredUsers WHERE Name = @Name AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@Password", TextBox2.Text);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("Login successful!");
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                }
            }
        }
    }
}
