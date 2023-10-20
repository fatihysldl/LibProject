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
    public class bookCategoryManager : IBookCategoryService
    {
        IBookCategoryDal _bookCategoryDal;

        public bookCategoryManager(IBookCategoryDal bookCategoryDal)
        {
            _bookCategoryDal = bookCategoryDal;
        }

        public void delete(bookCategory p)
        {
            _bookCategoryDal.delete(p);
        }

        public List<bookCategory> getAll()
        {
            return _bookCategoryDal.getAll();
        }

        public bookCategory getById(int Id)
        {
            return _bookCategoryDal.getById(Id);
        }

        public void insert(bookCategory p)
        {
            _bookCategoryDal.insert(p);
        }

        public void update(bookCategory p)
        {
            _bookCategoryDal.update(p);
        }
    }
}
