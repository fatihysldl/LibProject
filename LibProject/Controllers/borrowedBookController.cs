using BusinessLayer.abstracts;
using DataAccessLayer.concrete;
using EntityLayer.concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LibProject.Controllers
{
    public class borrowedBookController : Controller
    {
        private readonly IBorrowedBookService _borrowedBookService;
        private readonly context _dbContext;
        context c = new context();
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
        public IActionResult editBorrowedBook(int Id)
        {
            List<SelectListItem> memberValues = (from x in c.members.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.memberName,
                                                     Value = x.memberId.ToString()
                                                 }).ToList();
            List<SelectListItem> categoryValues = (from x in c.bookCategories.ToList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.category,
                                                       Value = x.categoryId.ToString()
                                                   }).ToList();

            List<SelectListItem> BookValues = (from x in c.books.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.bookName,
                                                   Value = x.bookId.ToString()
                                               }).ToList();

            ViewBag.v1 = memberValues; // Değişiklik burada
            ViewBag.v2 = categoryValues;
            ViewBag.v3 = BookValues;
            var datas = _borrowedBookService.getById(Id);
            return View(datas);
        }
        [HttpPost]
        public IActionResult editBorrowedBook(borrowedBook p)
        {
            _borrowedBookService.update(p);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult addBorrowedBook(int bookId)
        {
            var book = c.books.FirstOrDefault(b => b.bookId == bookId);

            // Book tablosundaki verileri addBorrowedBook Index sayfasına aktarır
            var borrowedBook = new borrowedBook
            {
                bookId = book.bookId,
                categoryId = book.categoryId,
            };

            //
            List<SelectListItem> memberValues = (from x in c.members.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.memberName,
                                                     Value = x.memberId.ToString()
                                                 }).ToList();
            List<SelectListItem> categoryValues = (from x in c.bookCategories.ToList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.category,
                                                       Value = x.categoryId.ToString()
                                                   }).ToList();

            List<SelectListItem> BookValues = (from x in c.books.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.bookName,
                                                   Value = x.bookId.ToString()
                                               }).ToList();

            ViewBag.v1 = memberValues;
            ViewBag.v2 = categoryValues;
            ViewBag.v3 = BookValues;


            return View(borrowedBook);

        }
        [HttpPost]
        public IActionResult addBorrowedBook(borrowedBook p, int bookId)
        {


            _borrowedBookService.insert(p);

            // Kitap stoğunu azaltma işlemini sadece ilgili kitap üzerinde yapmak için gerekli olan book
            var book = c.books.FirstOrDefault(b => b.bookId == bookId);
            if (book != null)
            {
                // Book tablosundaki bookStock değerini azaltir
                book.bookStock--;

                // Değişiklikleri kaydedin
                c.SaveChanges();
            }


            return RedirectToAction("Index");

        }

        public IActionResult deleteBorrowedBook(int Id)
        {
            var data = _borrowedBookService.getById(Id);
            _borrowedBookService.delete(data);
            var book = c.books.FirstOrDefault(b => b.bookId == data.bookId);
            if (book != null)
            {
                // Book tablosundaki bookStock değerini azaltir
                book.bookStock++;

                // Değişiklikleri kaydedin
                c.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
