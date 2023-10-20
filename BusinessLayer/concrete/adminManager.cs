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
    public class adminManager : IAdminService
    {
        IAdminDal _adminDal;

        public adminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void delete(admin p)
        {
            _adminDal.delete(p);
        }

        public List<admin> getAll()
        {
            return _adminDal.getAll();
        }

        public admin getById(int Id)
        {
            return _adminDal.getById(Id);
        }

        public void insert(admin p)
        {
            _adminDal.insert(p);
        }

        public void update(admin p)
        {
            _adminDal.update(p);
        }
    }
}
