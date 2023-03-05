using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProgrammersBlog.Entities.Concrete;

namespace ProgrammersBlog.Mvc.Models
{
    public class DenemeModel
    {
        public List<Article> ArticleList { get; set; }
        public Article Articles { get; set; }
    }
}
