using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    internal class Products
    {
        [Key]        
        public int ProductID { get; set; }
        public string ProductName {  get; set; }
        [Column(TypeName = "decimal (18,0)")]
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }  
    }
}
