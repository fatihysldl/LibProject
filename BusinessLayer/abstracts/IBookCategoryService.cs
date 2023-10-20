using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.abstracts
{
    public interface IBookCategoryService
    {
        void insert(bookCategory p);
        void update(bookCategory p);
        void delete(bookCategory p);
        List<bookCategory> getAll();
        bookCategory getById(int Id);
    }
}
