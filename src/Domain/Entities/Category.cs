using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        protected Category()
        {

        }

        public Category(string name, string type)
        {
            Id= Guid.NewGuid();
            Name= name;
            Type= type;
        }
    }
}
