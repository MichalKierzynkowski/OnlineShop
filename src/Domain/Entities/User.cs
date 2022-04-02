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
        public string Login { get; private set; }
        public string Password { get; private set; }

        protected User()
        {
            this.Id = Guid.NewGuid();
        }

        public User(string login, string password) : this()
        {
            Login = login;
            Password = password;
        }
    }
}