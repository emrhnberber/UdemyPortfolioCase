using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using UdemyPortfolioCase.DAL.Context;

namespace UdemyPortfolioCase.ViewComponents
{
    public class _ExperianceComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Experiances.ToList();
            return View(values);
        }
    }
}
