using Application.Dto.Category;
using Application.Dto.Product;
using AutoMapper;
using Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Mappings
{
  public static class AutoMaperConfig
  {
    public static void RegisterAutomapper(this IServiceCollection services)
    {
      services.AddSingleton<IMapper>(s => Initialize());
    }

    public static IMapper Initialize() => new MapperConfiguration(cfg =>
    {
        cfg.CreateMap<Product, GetProductDto>();

        cfg.CreateMap<CreateProductDto, Product>()
        .ForMember(x=>x.ProductDetail,opt=>opt.Ignore())
        .ForMember(x=>x.Category,opt=>opt.Ignore())
        .ForMember(x => x.Id, opt => opt.Ignore());

        cfg.CreateMap<Category, GetCategoryDto>();
        cfg.CreateMap<CreateCategoryDto, Category>()
        .ForMember(x => x.Products, opt => opt.Ignore())
        .ForMember(x => x.Id, opt => opt.Ignore());
    }) 
            .CreateMapper();
       

        
        
  }
}
