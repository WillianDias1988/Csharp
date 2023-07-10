using CleanArchMvc.Application.DTOs;

namespace CleanArchMvc.Application.Interfaces;

public interface IProductService
{
    Task<IEnumerable<ProductDTO>> GetProductsDTOAsync();
    Task<ProductDTO> GetProductDTOByIdAsync(int? id);
    Task CreateProductDTOAsync(ProductDTO productDTO);
    Task UpdateProductDTOAsync(ProductDTO productDTO);
    Task DeleteProductDTOAsync(int? id);

}
