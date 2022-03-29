using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TransactionReport
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid OrderId { get; set; }
        public Guid  ProductId { get; set; }
        public Guid PaymentId { get; set; }
        protected TransactionReport()
        {

        }
    }
}
