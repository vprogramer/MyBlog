using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string NameCategory { get; set; }
        public string DescriptionCategory { get; set; }
        public int IdArticle { get; set; }
    }
}
