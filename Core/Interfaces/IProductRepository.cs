using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {

        Task<Product> GetProductbyIdAsync(int id);

        Task<IReadOnlyList<Product>> GetAllProductAsync();



        Task<IReadOnlyList<ProductBrand>> GetAllProductBrandAsync();

        Task<IReadOnlyList<ProductType>> GetAllProductTypeAsync();
    }
}
