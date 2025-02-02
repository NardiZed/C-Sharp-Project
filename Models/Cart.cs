using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Project.Models
{
    public class Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartId { get; set; }

        [ForeignKey("Users")]
        public int UserId { get; set; }
        public Users Users { get; set; }

        [ForeignKey("Products")]
        public int ProductId { get; set; }
        public Products Products { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public double TotalPrice { get; set; }
    }
}