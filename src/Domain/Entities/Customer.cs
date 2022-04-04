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
        public Guid CustomerDetail { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
      
        public User User { get; set; }

        protected Customer()
        {

        }

        public Customer(string name,string surname,Guid CustomerDetail,Guid UserId)
        {
            Id= Guid.NewGuid();
            Name= name;
            Surname= surname;
            UserId= UserId;
            CustomerDetail= CustomerDetail;
        }
    }
}
