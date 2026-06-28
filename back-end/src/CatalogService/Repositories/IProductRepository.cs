using CatalogService.Models;

namespace CatalogService.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductModel>> GetAllAsync();
        Task<ProductModel?> GetByIdAsync(Guid id);
        Task<ProductModel?> AddAsync(ProductModel? product);
        Task<ProductModel?> UpdateAsync(ProductModel? product);
        Task<bool> DeleteAsync(Guid id);
    }
}
