using AutoMapper;
using GeekShopping.ProdutAPI.Data.ValueObjects;
using GeekShopping.ProdutAPI.Model;

namespace GeekShopping.ProdutAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config => 
            {
                config.CreateMap<ProductVO, Product>();
                config.CreateMap<Product, ProductVO>();
            });
            return mappingConfig;
        }
    }
}
