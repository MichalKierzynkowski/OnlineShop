﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductDetail
    {
        public Guid Id { get; set; }   
        public decimal SellingPrice { get; set; }
        public ICollection<Product> Products { get;set; }
        protected ProductDetail()
        {

        }

        public ProductDetail(decimal sellingPrice)
        {
            SellingPrice=sellingPrice;
        }
    }
}
