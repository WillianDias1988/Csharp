using AutoMapper;
using CleanArchMvc.Application.DTOs;
using CleanArchMvc.Application.Interfaces;
using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;

namespace CleanArchMvc.Application.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public ProductService(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task CreateProductDTOAsync(ProductDTO productDTO)
    {
        var productEntity = _mapper.Map<Product>(productDTO);
        await _productRepository.CreateProductAsync(productEntity);
    }

    public async Task DeleteProductDTOAsync(int? id)
    {
        var productEntity = _productRepository.GetByProductIdAsync(id).Result;
        await _productRepository.RemoveProductAsync(productEntity);
    }

    public async Task<ProductDTO> GetProductDTOByIdAsync(int? id)
    {
        var productEntity = await _productRepository.GetByProductIdAsync(id);
        return _mapper.Map<ProductDTO>(productEntity);
    }

    public async Task<IEnumerable<ProductDTO>> GetProductsDTOAsync()
    {
        var productEntity = await _productRepository.GetProductsAsync();
        return _mapper.Map<IEnumerable<ProductDTO>>(productEntity);
    }

    public async Task UpdateProductDTOAsync(ProductDTO productDTO)
    {
        var productEntity = _mapper.Map<Product>(productDTO);
        await _productRepository.UpdateProductAsync(productEntity);
    }
}
