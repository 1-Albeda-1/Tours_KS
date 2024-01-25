using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tours_KS.Context.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public int CountOfStars { get; set; }
        
        public string CountryCode { get; set; }
        
        public Country Country { get; set; }
        
        public string Description { get; set; }

        public ICollection<Tour> Tours { get; set; }
        public ICollection<HotelComment> HotelComments { get; set; }
        public ICollection<HotelImage> HotelImages { get; set; }
        public Hotel()
        {
            Tours = new HashSet<Tour>();
        }
    }
}
