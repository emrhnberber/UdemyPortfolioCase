using Microsoft.AspNetCore.Mvc;

namespace UdemyPortfolioCase.ViewComponents.LayoutViewComponents
{
    public class _LayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
