using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tours_KS.Context.Models;
using Type = Tours_KS.Context.Models.Type;

namespace Tours_KS.Context.DB 
{
    public class ToursContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelComment> HotelComments { get; set; }
        public DbSet<HotelImage> HotelImages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ReceivingPoint> ReceivingPoints {  get; set; }

        public ToursContext() : base("DefaultConnection") 
        {
            
        }
    }
}
