using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Blog.Models;
using Blog.Interfaces;
using Blog.Data;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;
        private readonly IArticle _article;
        private readonly ICategotyArticle _categotyArticle;
        private readonly ITagArticle _tagArticle;

        public HomeController(ILogger<HomeController> logger, ITagArticle tagArticle, ICategotyArticle categoty, IArticle article)
        {
            _logger = logger;
            _article = article;
            _categotyArticle = categoty;
            _tagArticle = tagArticle;
        }

        public IActionResult Index()
        {
            var Article = _article.getAllArticles();
            return View(Article);
        }

        public IActionResult Article(int id)
        {
            var post = _article.GetArticle(id);
            return View(post);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Category(int id)
        {
            var Category = _categotyArticle.GetCategory(id);
            return View(Category);
        }

        public IActionResult Tag(int id)
        {
            var Tag = _tagArticle.GetTag(id);
            return View(Tag);
        }

        [HttpGet]
        public IActionResult EditArticle()
        {
            return View(new Article());
        }

        [HttpPost]
        public async Task<IActionResult> EditArticle(Article article)
        {
            _article.AddArticle(article);
            if(await _article.SaveChangesAsync())
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(article);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
