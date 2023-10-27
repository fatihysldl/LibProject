using BusinessLayer.abstracts;
using EntityLayer.concrete;
using Microsoft.AspNetCore.Mvc;

namespace LibProject.Controllers
{
    public class bookCategoryController : Controller
    {
        private readonly IBookCategoryService _bookCategoryService;

        public bookCategoryController(IBookCategoryService bookCategoryService)
        {
            _bookCategoryService = bookCategoryService;
        }

        public IActionResult Index()
        {
            var values = _bookCategoryService.getAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult addCategory() 
        {
            return View();  
        }
        [HttpPost]
        public IActionResult addCategory(bookCategory p)
        {
            _bookCategoryService.insert(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult editCategory(int id)
        {
           var values= _bookCategoryService.getById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult editCategory(bookCategory p)
        {
            _bookCategoryService.update(p);
            return RedirectToAction("Index");
        }

        public IActionResult deleteCategory(int id)
        {
            var value = _bookCategoryService.getById(id);
            _bookCategoryService.delete(value);
            return RedirectToAction("Index");
        }

    }
}
