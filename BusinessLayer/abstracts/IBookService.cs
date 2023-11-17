using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.abstracts
{
    public interface IBookService
    {
        void insert(book p);
        void update(book p);
        void delete(book p);
        List<book> getAll();
        book getById(int Id);
        List<book> List(Expression<Func<book, bool>> filter);
    }
}
