using MarketWeb.Data;
using MarketWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarketWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db) 
        { 
            _db = db;
        }
        public IActionResult Index()
        {
            var getObjectCategory = _db.Categories.ToList();
            return View(getObjectCategory);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
