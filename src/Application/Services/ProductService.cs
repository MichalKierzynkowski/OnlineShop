using Application.Dto.Product;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
  public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }
        public IEnumerable<GetProductDto> GetAllProducts()
        {
            var products = _repository.GetAll();
            return _mapper.Map<IEnumerable<GetProductDto>>(products);
        }

        public GetProductDto GetProductById(Guid id)
        {
            var product = _repository.GetById(id);
            return _mapper.Map<GetProductDto>(product);
        }

        public Guid AddNewProduct(CreateProductDto newProduct)
        {
            var product = _mapper.Map<Product>(newProduct);

            _repository.Add(product);

            return product.Id;
        }

        public void UpdateProduct(Guid id, Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
