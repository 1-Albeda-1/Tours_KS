using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tours_KS.Context.Models
{
    public class Country
    {
        [Key] 
        public string Code { get; set; }
        
        public string Name { get; set; }
        
        public ICollection<Hotel> Hotels { get; set; }
        public ICollection<Tour> Tours { get; set; }

        public override string ToString()
         => Name;
    }
}
