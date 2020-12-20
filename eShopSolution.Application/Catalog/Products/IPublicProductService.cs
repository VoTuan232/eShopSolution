using eShopSolution.ViewModels.Catalog.Products;
using System.Collections.Generic;
using eShopSolution.ViewModels.Common;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);

        Task<List<ProductViewModel>> GetAll();
    }
}