using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tours_KS.Context.Models
{
    public class HotelComment
    {
        public int Id { get; set; }
        
        public int HotelId { get; set; }
        
        public Hotel Hotel { get; set; }
        
        public string Text { get; set; }
        
        public string Author { get; set; }
        
        public DateTimeOffset CreationDate { get; set; }

    }
}
