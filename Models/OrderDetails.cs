using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    internal class OrderDetails
    {
        [Key]
        public int OrderDetailsID { get; set; }
        public int Quantity { get; set; }
        public int ProductID { get; set; }
        public int OrderID { get; set; }
        public Orders orders { get; set; }
        public Products products { get; set; }
    }
}
