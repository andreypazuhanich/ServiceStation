using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using ServiceCatalog.Entities;

namespace ServiceCatalog.Repositories
{
    public interface IServiceItemRepository
    {
        Task<IEnumerable<ServiceItem>> GetServiceItems(Guid categoryId);
        Task<ServiceItem> GetServiceItemById(int id);
    }
}