using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }
        [Required]public string ProductName {  get; set; }
        [Column(TypeName = "decimal (18,0)")]
        [Required]public decimal ProductPrice { get; set; }
        [Required] public string Category {  get; set; }
        public string ProductDescription { get; set; }

        // Navigation Property
        public ICollection<OrderProduct> OrderProducts { get; set; }
        public ICollection<Cart> Carts { get; set; }
    }
}
