using BusinessLayer.abstracts;
using DataAccessLayer.concrete;
using EntityLayer.concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using static System.Net.Mime.MediaTypeNames;

namespace LibProject.Controllers
{
    public class bookController : Controller
    {
        private readonly IBookService _bookService;
        context c = new context();
        public bookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            var values = _bookService.getAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult addBook()
        {

            List<SelectListItem> values = (from x in c.bookCategories.ToList()
                                           select new SelectListItem
                                           { 
                                            Text=x.category,
                                            Value=x.categoryId.ToString()
                                           }).ToList() ;

            ViewBag.v1=values;  
            return View(); 
        }
        [HttpPost]
        public IActionResult addBook(book p)
        {
            _bookService.insert(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult editBook(int Id)
        {

            List<SelectListItem> values = (from x in c.bookCategories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.category,
                                               Value = x.categoryId.ToString()
                                           }).ToList();

            ViewBag.v2 = values;
            var datas = _bookService.getById(Id);
            return View(datas);
        }
        [HttpPost]
        public IActionResult editBook(book p)
        {
            _bookService.update(p);
            return RedirectToAction("Index");
        }
        public IActionResult deleteBook(int Id)
        {
            var data = _bookService.getById(Id);
            _bookService.delete(data);
            return RedirectToAction("Index");
        }
    }
}
