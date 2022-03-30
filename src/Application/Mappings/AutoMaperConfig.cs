using Application.Dto.Product;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public static class AutoMaperConfig
    {
        public static IMapper Initialize() => new MapperConfiguration(cfg =>
        {
            #region Product
            cfg.CreateMap<Product, GetProductDto>();

            #endregion

        }
        ).CreateMapper();
    
}
}
