using Microsoft.AspNetCore.Mvc;
using UdemyPortfolioCase.DAL.Context;
using UdemyPortfolioCase.DAL.Entities;

namespace UdemyPortfolioCase.Controllers
{
    public class ExperianceController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult ExperianceList()
        {
            var values = context.Experiances.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateExperiance()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperiance(Experiance experiance)
        {
            context.Experiances.Add(experiance);
            context.SaveChanges();
            return RedirectToAction("ExperianceList");
        }

        public IActionResult DeleteExperiance(int id)
        {
            var value = context.Experiances.Find(id);
            context.Experiances.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ExperianceList");
        }

        [HttpGet]
        public IActionResult UpdateExperiance(int id)
        {
            var value = context.Experiances.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateExperiance(Experiance experiance)
        {
            context.Experiances.Update(experiance);
            context.SaveChanges();
            return RedirectToAction("ExperianceList");
        }
    }
}
