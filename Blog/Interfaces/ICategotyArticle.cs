using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Interfaces
{
    public interface ICategotyArticle
    {
        List<Category> getAllCategoties();
        Category GetCategory(int id);
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void RemoveCategory(int id);
        Task<bool> SaveChangesAsync();
    }
}
