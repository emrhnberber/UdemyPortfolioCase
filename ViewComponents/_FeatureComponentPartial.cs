using Microsoft.AspNetCore.Mvc;
using UdemyPortfolioCase.DAL.Context;

namespace UdemyPortfolioCase.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList();
            return View(values);
        }
    }
}
