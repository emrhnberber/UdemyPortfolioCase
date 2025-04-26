using Microsoft.AspNetCore.Mvc;

namespace UdemyPortfolioCase.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
