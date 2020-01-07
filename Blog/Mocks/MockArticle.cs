using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data;
using Blog.Interfaces;
using Blog.Models;

namespace Blog.Mocks
{
    public class MockArticle : IArticle
    {
        private ApplicationDbContext _repository;
        public MockArticle(ApplicationDbContext repository)
        {
            _repository = repository;
        }
        public void AddArticle(Article article)
        {
            _repository.Articles.Add(article);
        }

        public List<Article> getAllArticles()
        {
            return _repository.Articles.ToList();
        }

        public Article GetArticle(int id)
        {
            return _repository.Articles.FirstOrDefault(p => p.Id == id);
        }

        public void RemoveArticle(int id)
        {
            _repository.Articles.Remove(GetArticle(id));
        }

        public void UpdateArticle(Article article)
        {
            _repository.Articles.Update(article);
        }
        public async Task<bool> SaveChangesAsync()
        {
            if(await _repository.SaveChangesAsync() > 0)
            {
                return true;
            }
            return false;
        }
    }
}
