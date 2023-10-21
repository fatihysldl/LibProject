using BusinessLayer.abstracts;
using BusinessLayer.concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.concrete;
using Microsoft.AspNetCore.Mvc;

namespace LibProject.Controllers
{
    public class memberController : Controller
    {
        private readonly IMemberService _memberService;

        public memberController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var datas = _memberService.getAll();
            return View(datas);
        }

        [HttpGet]
        public IActionResult addMember()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addMember(member p)
        {
            _memberService.insert(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult editMember(int Id)
        {
            var datas = _memberService.getById(Id);
            return View(datas);
        }
        [HttpPost]
        public IActionResult editMember(member p)
        {
            _memberService.update(p);
            return RedirectToAction("Index");
        }

        public IActionResult deleteMember(int Id) 
        {
            var data = _memberService.getById(Id);
            _memberService.delete(data);
            return RedirectToAction("Index");
        }
    }
}
