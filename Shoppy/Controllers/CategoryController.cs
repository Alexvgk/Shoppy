using Microsoft.AspNetCore.Mvc;
using Shoppy.Data;
using Shoppy.Models;

namespace Shoppy.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ShoppyDBContext _db;

        public CategoryController(ShoppyDBContext dBContext)
        {
            _db = dBContext;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> objList = _db.Category;
            return View(objList);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
