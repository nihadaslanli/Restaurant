using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Areas.Admin.Controllers
{
    public class DashBoardController : AdminContoller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
