﻿using System;
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

   
        public ICollection<Hotel> Hotels { get; set; }

        public ICollection<Type> Types { get; set; }
        public ICollection<Order> Orders { get; set; }

        public Tour()
        {
            Hotels = new HashSet<Hotel>();
            Types = new HashSet<Type>();
            Orders = new HashSet<Order>();
        }
    }
}