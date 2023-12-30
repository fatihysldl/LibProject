using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.abstracts
{
    public interface IBorrowedBookService
    {
        void insert(borrowedBook p);
        void update(borrowedBook p);
        void delete(borrowedBook p);
        List<borrowedBook> getAll();
        borrowedBook getById(int Id);
    }
}
