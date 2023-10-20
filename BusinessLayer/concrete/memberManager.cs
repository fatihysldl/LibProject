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
    public class memberManager : IMemberService
    {
        IMemberDal _memberDal;

        public memberManager(IMemberDal memberDal)
        {
            _memberDal = memberDal;
        }

        public void delete(member p)
        {
            _memberDal.delete(p);
        }

        public List<member> getAll()
        {
            return _memberDal.getAll();
        }

        public member getById(int Id)
        {
            return _memberDal.getById(Id);
        }

        public void insert(member p)
        {
            _memberDal.insert(p);
        }

        public void update(member p)
        {
            _memberDal.update(p);
        }
    }
}
