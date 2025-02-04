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
        }

        private async void Home_Page_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ECommerceContext())
                {
                    var products = await context.Products.ToListAsync();
                    AddProductsToListBox(products);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddProductsToListBox(List<Products> products)
        {
            if (listBox1.InvokeRequired)
            {
                listBox1.Invoke(new Action(() => AddProductsToListBox(products)));
            }
            else
            {
                listBox1.Items.Clear();

                foreach (var product in products)
                {
                    listBox1.Items.Add($"{product.ProductName}");
                }
            }
        }
    }
}