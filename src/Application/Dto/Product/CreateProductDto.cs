using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Product
{
    public class CreateProductDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
