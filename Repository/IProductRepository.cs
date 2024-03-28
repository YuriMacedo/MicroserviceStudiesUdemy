using GeekShopping.ProdutAPI.Data.ValueObjects;

namespace GeekShopping.ProdutAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductVO>> GetAll();
        Task<ProductVO> FindById(long id);
        Task<ProductVO> Create(ProductVO product);
        Task<ProductVO> Update(ProductVO product);
        Task<bool> DeleteById(long id);
    }
}
