using BusinessLayer.abstracts;
using BusinessLayer.concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.concrete;
using Microsoft.AspNetCore.Mvc;
using System.Security.Permissions;

namespace LibProject.Controllers
{
    public class adminLoginController : Controller
    {
        private readonly IAdminService _admin;

        public adminLoginController(IAdminService admin)
        {
            _admin = admin;
        }

        public IActionResult Index()
        {
            var datas = _admin.getAll();
            return View(datas);
        }
        [HttpGet]
        public IActionResult addAdmin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addAdmin(admin p)
        {
            _admin.insert(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult editAdmin(int id)
        {
            var data=_admin.getById(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult editAdmin(admin p)
        {
            _admin.update(p);
            return RedirectToAction("Index");
        }

        public IActionResult deleteAdmin(int id)
        {
            var data= _admin.getById(id);
            _admin.delete(data);
            return RedirectToAction("Index");
        }
    }
}
