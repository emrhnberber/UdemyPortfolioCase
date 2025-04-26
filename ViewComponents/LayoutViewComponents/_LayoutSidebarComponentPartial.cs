using Microsoft.AspNetCore.Mvc;

namespace UdemyPortfolioCase.ViewComponents.LayoutViewComponents
{
    public class _LayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
