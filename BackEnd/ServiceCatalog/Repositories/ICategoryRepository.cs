using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using ServiceCatalog.Entities;

namespace ServiceCatalog.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategories();
        Task<Category> GetCategoryById(string categoryId);
    }
}