﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tours_KS.Context.Models
{
    public class User
    {
        public int Id { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string Patronymic { get; set; }
        
        public string Login { get; set; }
        
        public string Password { get; set; }
        
        public Role RoleType { get; set; }

        public virtual ICollection<Order> Order { get; set; }

    }
}
