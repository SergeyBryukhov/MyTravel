using System;
using Microsoft.AspNetCore.Mvc;
using MyTravels.Domain;

namespace MyCompany.Controllers
{
    public class TravelsController : Controller
    {
        private readonly DataManager dataManager;

        public TravelsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.HistoryTravel.GetHistoryTravelById(id));
            }

            ViewBag.TextFoMi = dataManager.TextFoMi.GetTextFoMiByCodeWord("PageTravels");
            return View(dataManager.HistoryTravel.GetHistoryTravels());
        }
    }
}