using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data;
using Blog.Interfaces;
using Blog.Models;

namespace Blog.Mocks
{
    public class MockCategory : ICategotyArticle
    {
        private ApplicationDbContext _context;
        public MockCategory(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
        }

        public List<Category> getAllCategoties()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategory(int id)
        {
            return _context.Categories.FirstOrDefault(p => p.Id == id);
        }

        public void RemoveCategory(int id)
        {
            _context.Categories.Remove(GetCategory(id));
        }

        public void UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
        }
        public async Task<bool> SaveChangesAsync()
        {
            if (await _context.SaveChangesAsync() > 0)
            {
                return true;
            }
            return false;
        }
    }
}
