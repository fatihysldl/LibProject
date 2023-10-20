using Microsoft.AspNetCore.Mvc;

namespace LibProject.Controllers
{
    public class layoutPartialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult scripts()
        {
            return PartialView();
        }
        public PartialViewResult head()
        {
            return PartialView();
        }
        public PartialViewResult navbar()
        {
            return PartialView();
        }
    }
}
