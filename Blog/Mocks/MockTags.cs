using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data;
using Blog.Interfaces;
using Blog.Models;

namespace Blog.Mocks
{
    public class MockTags: ITagArticle
    {
        private ApplicationDbContext _context;
        public MockTags(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddTag(Tag tag)
        {
            _context.Tags.Add(tag);
        }

        public List<Tag> getAllTag()
        {
            return _context.Tags.ToList();
        }

        public Tag GetTag(int id)
        {
            return _context.Tags.FirstOrDefault(p => p.Id == id);
        }

        public void RemoveTag(int id)
        {
            _context.Tags.Remove(GetTag(id));
        }

        public void UpdateTag(Tag tag)
        {
            _context.Tags.Update(tag);
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
