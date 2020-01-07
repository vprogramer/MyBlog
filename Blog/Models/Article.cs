using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        //public int IdUser { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string Body { get; set; } = "";
        public string Photo { get; set; } = "";
        public DateTime Date { get; set; } = DateTime.Now;
        public virtual ICollection<Tag> Tags { get; set; } //public virtual Tag Tags { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
    }
}
