using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Splash_Screen : Form
    {
        public Splash_Screen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Panel2.Width += 3;
            if(Panel2.Width >= 895)
            {
                timer1.Stop();
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Dispose();
            }
        }
    }
}
