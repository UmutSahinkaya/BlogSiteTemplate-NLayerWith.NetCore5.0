using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProgrammersBlog.Data.Concrete.EntityFramework.Contexts;
using ProgrammersBlog.Mvc.Models;

namespace ProgrammersBlog.Mvc.Controllers
{
    public class HomeController : Controller
    {
        ProgrammersBlogContext c = new ProgrammersBlogContext();
        private DenemeModel model = new DenemeModel();
        public IActionResult Index()
        {
            model.ArticleList = c.Articles.ToList();
            //ViewBag.Deneme = deger.ToString();

            return View(model);
        }
    }
}
