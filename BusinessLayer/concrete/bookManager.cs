using BusinessLayer.abstracts;
using DataAccessLayer.abstracts;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.concrete
{
    public class bookManager : IBookService
    {
        IBookDal _bookDal;

        public bookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public void delete(book p)
        {
            _bookDal.delete(p);
        }

        public List<book> getAll()
        {
           return _bookDal.getAll();
        }


        public book getById(int Id)
        {
           return _bookDal.getById(Id);
        }

        public void insert(book p)
        {
            _bookDal.insert(p);
        }

        public List<book> List(Expression<Func<book, bool>> filter)
        {
            return _bookDal.List(filter);
        }

        public void update(book p)
        {
            _bookDal.update(p);
        }
    }
}
