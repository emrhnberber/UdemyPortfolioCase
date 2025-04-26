using Microsoft.AspNetCore.Mvc;

namespace UdemyPortfolioCase.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
