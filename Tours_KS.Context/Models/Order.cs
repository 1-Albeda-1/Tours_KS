using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tours_KS.Context.Models
{
    public class Order
    {
        public int Id { get; set; }
        
        public User UserId { get; set; }
        
        public string User { get; set; }
        
        public decimal Price { get; set; }
        
        public DateTimeOffset OrderDate { get; set; }
        
        public short AllSale {  get; set; }
        public ICollection<Tour> Tours { get; set; }
        
        public Order()
        {
            Tours = new HashSet<Tour>();
        }
    }
}
