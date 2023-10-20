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
        IBorrowedBookDal _borrowedBookDal;

        public borrowedBookManager(IBorrowedBookDal borrowedBookDal)
        {
            _borrowedBookDal = borrowedBookDal;
        }

        public void delete(borrowedBook p)
        {
            _borrowedBookDal.delete(p);
        }

        public List<borrowedBook> getAll()
        {
            return _borrowedBookDal.getAll();
        }

        public borrowedBook getById(int Id)
        {
            return _borrowedBookDal.getById(Id);
        }

        public void insert(borrowedBook p)
        {
            _borrowedBookDal.insert(p);
        }

        public void update(borrowedBook p)
        {
            _borrowedBookDal.update(p);
        }
    }
}
