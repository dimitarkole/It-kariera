using CHUSHKA.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHUSHKA.Services.Contracts
{
    public interface IProductService
    {
        ICollection<ProductInfoViewModel> GetAllProducts();
    }
}
