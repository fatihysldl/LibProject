using BusinessLayer.abstracts;
using DataAccessLayer.abstracts;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.concrete
{
    public class borrowedBookManager : IBorrowedBookService
    {
        IBorrowedBookDal _borrowedBook;

        public borrowedBookManager(IBorrowedBookDal borrowedBook)
        {
            _borrowedBook = borrowedBook;
        }

        public void delete(borrowedBook p)
        {
            _borrowedBook.delete(p);
        }

        public List<borrowedBook> getAll()
        {
            return _borrowedBook.getAll();
        }

        public borrowedBook getById(int Id)
        {
            return _borrowedBook.getById(Id);
        }

        public void insert(borrowedBook p)
        {
            _borrowedBook.insert(p);
        }

        public void update(borrowedBook p)
        {
            _borrowedBook.update(p);
        }
    }
}
