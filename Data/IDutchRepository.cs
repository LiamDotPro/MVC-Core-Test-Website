using System.Collections.Generic;
using Bootstrap.Data.Entities;

namespace Bootstrap.Data
{
    public interface IDutchRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByCategory(string category);
    }
}