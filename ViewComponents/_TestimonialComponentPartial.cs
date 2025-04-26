using Microsoft.AspNetCore.Mvc;

namespace UdemyPortfolioCase.ViewComponents
{
    public class _TestimonialComponentPartial :  ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
