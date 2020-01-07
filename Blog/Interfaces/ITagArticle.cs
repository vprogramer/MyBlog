using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Interfaces
{
    public interface ITagArticle
    {
        List<Tag> getAllTag();
        Tag GetTag(int id);
        void AddTag(Tag tag);
        void UpdateTag(Tag tag);
        void RemoveTag(int id);
        Task<bool> SaveChangesAsync(); 
    }
}
