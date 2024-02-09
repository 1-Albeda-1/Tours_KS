using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tours_KS.Context.Models;

namespace Tours_KS
{
    internal static class Users
    {
        private static User user;
        public static User User
        {
            get
            {
                if (user == null)
                {
                    user = new User()
                    {
                        Id = -1,
                        FirstName = "Неавторизованный гость",
                        LastName = string.Empty,
                        Patronymic = string.Empty,
                        RoleType = Role.Administrator
                    };
                }
                return user;
            }
            set { user = value; }
        }

        internal static bool CompareRole(Role role)
         => role == User.RoleType;
    }
}
