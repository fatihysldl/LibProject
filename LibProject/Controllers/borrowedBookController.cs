using BusinessLayer.abstracts;
using DataAccessLayer.concrete;
using EntityLayer.concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibProject.Controllers
{
    public class borrowedBookController : Controller
    {
        private readonly IBorrowedBookService _borrowedBookService;
        private readonly context _dbContext;
        public borrowedBookController(IBorrowedBookService borrowedBookService, context dbContext)
        {
            _borrowedBookService = borrowedBookService;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var borrowedBooks = _dbContext.borrowedBooks
                 .Include(b => b.member)
              .Include(b => b.book)
             .Include(b => b.category)
              .ToList();
            var values = _borrowedBookService.getAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult addBorrowedBooks()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addBorrowedBooks(borrowedBook p)
        {
            _borrowedBookService.insert(p);
            return RedirectToAction("Index");
        }
    }
}
