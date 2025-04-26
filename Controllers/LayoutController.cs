using Microsoft.AspNetCore.Mvc;

namespace UdemyPortfolioCase.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
