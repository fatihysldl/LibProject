using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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

    }
}
