using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebShopApp.Core.Contracts;
using WebShopApp.Infrastructure.Data;
using WebShopApp.Infrastructure.Data.Domain;

namespace WebShopApp.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;

            public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Category GetCategoryById(int categoryId) 
        {
            return _context.Categories.Find(categoryId);
        }
        public List<Category> GetAllCategories()
        {
            List<Category> categories = _context.Categories.ToList();
            return categories;
        }
        public List<Product> GetProductsByCategory(int categoryId) 
        {
            return _context.Products
                .Where(x => x.CategoryId == categoryId)
                .ToList();
        }

        public List<Category> GetCategories()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
    
   
}
