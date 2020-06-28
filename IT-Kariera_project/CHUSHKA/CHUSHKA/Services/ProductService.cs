using CHUSHKA.Data;
using CHUSHKA.Models.Home;
using CHUSHKA.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHUSHKA.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext dbContext;

        public ProductService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public ICollection<ProductInfoViewModel> GetAllProducts()
        {
            return this.dbContext.Products.Select(
                p => new ProductInfoViewModel()
                {
                    Id = p.Id,
                    Price = p.Price,
                    Description = p.Description,
                    Name = p.Name
                }
                ).ToList();
        }
    }
}
