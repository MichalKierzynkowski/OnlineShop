using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public CustomerDetail CustomerDetail { get; set; }
        public User User { get; set; }

        protected Customer()
        {

        }

        public Customer(string name,string surname)
        {
            Id= Guid.NewGuid();
            Name= name;
            Surname= surname;
        }
    }
}
