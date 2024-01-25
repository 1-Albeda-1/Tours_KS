using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tours_KS.Context.Models
{
    public class HotelImage
    {
        public int Id { get; set; }
        
        public int HotelId { get; set; }
        
        public Hotel Hotel { get; set; }
        
        public byte[] ImageSource { get; set; }
        
        public string ImageType { get; set; }

    }
}
