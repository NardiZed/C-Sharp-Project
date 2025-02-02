using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Project.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        [ForeignKey("Users")] // Corrected to match the Users class
        public int UserId { get; set; }
        public Users Users { get; set; } // Corrected to match the Users class

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }

        [Required]
        public string ShippingAddress { get; set; }

        [Required]
        public string OrderStatus { get; set; }

        // Navigation Property
        public ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
    }
}