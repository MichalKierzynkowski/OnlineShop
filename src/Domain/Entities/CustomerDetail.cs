using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CustomerDetail
    {
        public Guid Id { get; set; }
        public string HomeTown { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string PostalCode { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        protected CustomerDetail()
        {

        }
    }
}
