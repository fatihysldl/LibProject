using BusinessLayer.abstracts;
using EntityLayer.concrete;
using Microsoft.AspNetCore.Mvc;

namespace LibProject.Controllers
{
    public class bookController : Controller
    {
        private readonly IBookService _bookService;

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
            return View();
        }
        [HttpPost]
        public IActionResult addBook(book p)
        {
            _bookService.insert(p);
            return RedirectToAction("Index");
        }
    }
}
