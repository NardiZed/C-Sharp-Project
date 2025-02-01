using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;

namespace Final_Project.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        [Required]public DateTime OrderDate { get; set; }
        [Required] public decimal TotalAmount { get; set; }
        [Required] public string ShippingAddress { get; set; }
        [Required] public string OrderStatus { get; set; }

        // Navigation Property
        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
