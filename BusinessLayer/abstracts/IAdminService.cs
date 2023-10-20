using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.abstracts
{
    public interface IAdminService
    {
        void insert(admin p);
        void update(admin p);
        void delete(admin p);
        List<admin> getAll();
        admin getById(int Id);
    }
}
