﻿using AutoMapper;
using GeekShopping.ProdutAPI.Data.ValueObjects;
using GeekShopping.ProdutAPI.Model;
using GeekShopping.ProdutAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProdutAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MySqlContext _context;
        private readonly IMapper _mapper;

        public ProductRepository(MySqlContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ProductVO>> GetAll()
        {
            var products = await _context.Products.ToListAsync();
            return _mapper.Map<List<ProductVO>>(products);
        }
        public async Task<ProductVO> FindById(long id)
        {
            var product = await _context.Products
                .Where(p => p.Id == id).FirstOrDefaultAsync();

            return _mapper.Map<ProductVO>(product);
        }

        public async Task<ProductVO> Create(ProductVO product)
        {
            Product productEntity = _mapper.Map<Product>(product);
            _context.Products.Add(productEntity);
            await _context.SaveChangesAsync();

            return _mapper.Map<ProductVO>(productEntity);
        }
        public async Task<ProductVO> Update(ProductVO product)
        {
            Product productEntity = _mapper.Map<Product>(product);
            _context.Products.Update(productEntity);
            await _context.SaveChangesAsync();

            return _mapper.Map<ProductVO>(productEntity);
        }
        public async Task<bool> DeleteById(long id)
        {
            try
            {
                var product = await _context.Products
                .Where(p => p.Id == id).FirstOrDefaultAsync();

                if (product == null) return false;

                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}
