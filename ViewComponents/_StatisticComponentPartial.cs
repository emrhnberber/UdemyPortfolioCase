﻿using Microsoft.AspNetCore.Mvc;

namespace UdemyPortfolioCase.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
