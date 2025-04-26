using Microsoft.AspNetCore.Mvc;

namespace UdemyPortfolioCase.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
