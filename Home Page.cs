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

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (var context = new ECommerceContext())
            {
                var Electronics = context.Products
                                   .Where(p => p.Category == "Electronics")
                                   .ToList();

                foreach (var product in Electronics)
                {
                    Panel name = new Panel
                    {
                        Size = new Size(240, 390), // Adjust width to fit 4 panels in 1099px width (with margins)
                        BackColor = Color.Black,
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(5) // Add some margin to separate panels
                    };

                    Label label1 = new Label
                    {
                        Text = product.ProductName,
                        Font = new Font("Serif", 14, FontStyle.Bold),
                        ForeColor = Color.White,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Top,
                        Height = 40,
                    };

                    Label label2 = new Label
                    {
                        Text = $"Price: {product.ProductPrice:F2}",
                        Font = new Font("Serif", 11, FontStyle.Regular),
                        ForeColor = Color.White,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Top,
                        Height = 30,
                    };

                    PictureBox picBox = new PictureBox
                    {
                        Image = null,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Dock = DockStyle.Top,
                        Height = 200,
                    };

                    Label label3 = new Label
                    {
                        Text = $"Description: {product.ProductDescription}",
                        Font = new Font("Serif", 10, FontStyle.Italic),
                        ForeColor = Color.White,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Size = new Size(250, 60),
                        Dock = DockStyle.Top,
                    };

                    Button addButton = new Button
                    {
                        Text = "+",
                        Font = new Font("Serif", 15),
                        ForeColor = Color.White,
                        BackColor = Color.LightGreen,
                        Height = 40,
                        Dock = DockStyle.Bottom,
                    };
                }
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            using (var context = new ECommerceContext()) {
            var Electronics = context.Products
                                   .Where(p => p.Category == "Electronics")
                                   .ToList();

            foreach (var product in Electronics)
            {
                Panel name = new Panel
                {
                    Size = new Size(240, 390), // Adjust width to fit 4 panels in 1099px width (with margins)
                    BackColor = Color.Black,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5) // Add some margin to separate panels
                };

                Label label1 = new Label
                {
                    Text = product.ProductName,
                    Font = new Font("Serif", 14, FontStyle.Bold),
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Top,
                    Height = 40,
                };

                Label label2 = new Label
                {
                    Text = $"Price: {product.ProductPrice:F2}",
                    Font = new Font("Serif", 11, FontStyle.Regular),
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Top,
                    Height = 30,
                };

                PictureBox picBox = new PictureBox
                {
                    Image = null,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Dock = DockStyle.Top,
                    Height = 200,
                };

                Label label3 = new Label
                {
                    Text = $"Description: {product.ProductDescription}",
                    Font = new Font("Serif", 10, FontStyle.Italic),
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(250, 60),
                    Dock = DockStyle.Top,
                };

                Button addButton = new Button
                {
                    Text = "+",
                    Font = new Font("Serif", 15),
                    ForeColor = Color.White,
                    BackColor = Color.LightGreen,
                    Height = 40,
                    Dock = DockStyle.Bottom,
                };
            }
        }
    }
    }
}