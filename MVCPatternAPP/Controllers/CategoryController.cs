using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPatternAPP.Entity.Models;
using MVCPatternAPP.Service.Service;

namespace MVCPatternAPP.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryService _categoryService;

        public CategoryController()
        {
            _categoryService = new CategoryService();
        }
        
        public ActionResult Index()
        {
            IEnumerable<Category> categories = _categoryService.GetCategories();
            return View(categories);
        }
    }
}