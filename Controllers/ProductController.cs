using Microsoft.AspNetCore.Mvc;
using Self_Practice.DAL;

namespace Self_Practice.Controllers
{
    public class ProductController : Controller
    {
        //private readonly MyAppDbContext _context;

        //public ProductController(MyAppDbContext context)
        //{
        //    _context = context;
        //}
        private readonly MyAppDbContext _context;

        public ProductController(MyAppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        //public JsonResult GetProducts() { 
        //    var products = _context.Products.ToList();
        //    return Json(products);
        //}

        [HttpGet]
        public JsonResult GetProducts()
        {
            var products = _context.Products.ToList();
            return Json(products);
        }
    }
}
