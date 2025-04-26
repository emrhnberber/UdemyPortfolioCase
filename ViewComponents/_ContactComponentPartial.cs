using Microsoft.AspNetCore.Mvc;

namespace UdemyPortfolioCase.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
