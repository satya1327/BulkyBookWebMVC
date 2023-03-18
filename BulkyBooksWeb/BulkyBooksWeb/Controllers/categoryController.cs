using BulkyBooksWeb.Data;
using BulkyBooksWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBooksWeb.Controllers
{
    public class categoryController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public categoryController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _applicationDbContext.categories;
            return View(objCategoryList);
        }
        //Get
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public IActionResult Create(Category obj)
        {
            var data = new Category()
            {
                Name = obj.Name,
                DisplayOrder = obj.DisplayOrder

            };
            if (data.Name == null || data.DisplayOrder==0 )
            {
                return RedirectToAction("Create");
            }_applicationDbContext.categories.Add(data);
           
            _applicationDbContext.SaveChanges();
           
            return RedirectToAction("Index");


        }
    }
}
