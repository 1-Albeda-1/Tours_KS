using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tours_KS.Context.Models
{
    public class ReceivingPoint
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        public override string ToString()
         => $"{Name}  {Address}";
    }
}
