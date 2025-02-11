using Final_Project.Data;
using Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
            this.Load += Home_Page_Load;
            string[] cat = { "Automotive", "Books", "Cosmetics", "Electronics", "Fashion", "Stationary" };
            comboBox1 = new ComboBox();
            foreach (string catName in cat)
            {
                comboBox1.Items.Add(catName);
            }
        }

        private async void Home_Page_Load(object sender, EventArgs e)
        {

        }
    }
}