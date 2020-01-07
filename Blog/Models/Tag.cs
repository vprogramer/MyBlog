using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string NameTag {get; set;}
        public int IdArticle { get; set; }
    }
}
