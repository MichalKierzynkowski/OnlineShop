using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
   public class User
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Customer Customer { get; set; }
        protected User()
        {
            
        }

        public User(string login, string password)
        {
            Login=login;
            Password=password;
        }
    }
}
