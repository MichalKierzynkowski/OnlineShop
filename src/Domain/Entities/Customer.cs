using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public Guid CustomerDetailId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        protected Customer()
        {

        }
    }
}
