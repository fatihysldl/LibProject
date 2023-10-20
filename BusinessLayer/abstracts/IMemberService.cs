using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.abstracts
{
    public interface IMemberService
    {
        void insert(member p);
        void update(member p);
        void delete(member p);
        List<member> getAll();
        member getById(int Id);
    }
}
