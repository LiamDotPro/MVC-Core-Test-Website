using System.Collections.Generic;
using Bootstrap.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Bootstrap.Data
{
    public interface IDutchRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByCategory(string category);
        IEnumerable<Order> getAllOrders();
    }
}