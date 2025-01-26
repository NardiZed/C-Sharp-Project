using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    internal class Orders
    {
        public int OrderID { get; set; }
        public DateTime OrderCreated { get; set; } = DateTime.Now;
        public int UserID { get; set; }
        public Users User { get; set; }
        public ICollection<OrderDetails> orderDetails {get; set;}

    }
}
