using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceCatalog.DbContexts;
using ServiceCatalog.Entities;

namespace ServiceCatalog.Repositories
{
    public class ServiceItemRepository : IServiceItemRepository
    {
        private readonly ServiceCatalogDbContext _context;

        public ServiceItemRepository(ServiceCatalogDbContext context)
        {
            _context = context;
        }
        
        public async Task<IEnumerable<ServiceItem>> GetServiceItems(Guid categoryId)
        {
            return await _context.ServiceItems.Include(s => s.Category)
                .Where(s => s.CategoryId == categoryId || categoryId == Guid.Empty).ToListAsync();
        }

        public async Task<ServiceItem> GetServiceItemById(int id)
        {
            return await _context.ServiceItems.FirstOrDefaultAsync(s => s.ServiceItemId == id);
        }
    }
}