using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;

namespace Blog.Interfaces
{
    public interface IArticle
    {
        List<Article> getAllArticles();
        Article GetArticle(int id);
        void AddArticle(Article article);
        void UpdateArticle(Article article);
        void RemoveArticle(int id);
        Task<bool> SaveChangesAsync();

        //IEnumerable<Article> articleCategory { get; set; }
       // IEnumerable<Article> articleTag { get; set; }
        //Article deleteArticle(string nameArticle);
    }
}
