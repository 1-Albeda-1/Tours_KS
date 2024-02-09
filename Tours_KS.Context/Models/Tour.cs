using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tours_KS.Context.Models
{
    public class Tour
    {
        public int Id { get; set; }

        public int TicketCount { get; set; }
        
        public string Name { get; set; }

        public string Description { get; set; }

        public byte[] ImagePreview { get; set; }

        public decimal Price { get; set; }

        public bool IsActual { get; set; }
        
        public string CountryCode { get; set; }

        public virtual Country Country { get; set; }


        public virtual ICollection<Hotel> Hotels { get; set; }

        public virtual ICollection<Type> Types { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        public Tour()
        {
            Hotels = new HashSet<Hotel>();
            Types = new HashSet<Type>();
            Orders = new HashSet<Order>();
        }

        public override int GetHashCode()
         => Id.GetHashCode();

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj is Tour tour)
            {
                return tour.Id.Equals(Id);
            }

            return false;
        }
    }
}
