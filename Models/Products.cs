using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Project.Models
{
    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Column(TypeName = "decimal(18,0)")]
        [Required]
        public decimal ProductPrice { get; set; }

        [Required]
        public string Category { get; set; }

        public string ProductDescription { get; set; }

        public Image Image { get; set; }

        // Navigation Properties
        public ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
        public ICollection<Cart> Carts { get; set; } = new List<Cart>();
    }
}