using Bootstrap.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootstrap.Data
{
    public class DutchRepository : IDutchRepository
    {
        private readonly DutchContext _ctx;

        public DutchRepository(DutchContext ctx)
        {
            _ctx = ctx;
        }

        /// <summary>
        /// Gets a list of all products that are avalible from the database.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Product> GetAllProducts()
        {
            return _ctx.Products.OrderBy(p => p.Title).ToList();
        }

        /// <summary>
        /// Gets all products by a catageory
        /// </summary>
        /// <param name="category">The category of the item.</param>
        /// <returns>A collection of products by category.</returns>
        public IEnumerable<Product> GetProductsByCategory(string category)
        {
            return _ctx.Products.Where(p => p.Category == category).ToList();
        }

        /**
         * The SaveChanges method saves all of the changes that have been made to the context to the underlying database.
         */ 
        public bool SaveAll() {
            return _ctx.SaveChanges() > 0;
        }
    }
}
