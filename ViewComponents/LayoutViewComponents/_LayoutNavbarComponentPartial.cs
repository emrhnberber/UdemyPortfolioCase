using Microsoft.AspNetCore.Mvc;
using UdemyPortfolioCase.DAL.Context;

namespace UdemyPortfolioCase.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            ViewBag.toDoListCount= context.ToDoLists.Where(x=>x.status == false).Count();
            var values = context.ToDoLists.Where(x => x.status == false).ToList();
            return View(values);
        }
    }
}
