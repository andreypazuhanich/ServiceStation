using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceCatalog.DbContexts;
using ServiceCatalog.Entities;

namespace ServiceCatalog.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ServiceCatalogDbContext _context;

        public CategoryRepository(ServiceCatalogDbContext context)
        {
            _context = context;
        }
        
        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryById(string categoryId)
        {
            return await _context.Categories.FirstOrDefaultAsync(s => s.CategoryId == Guid.Parse(categoryId));
        }
    }
}