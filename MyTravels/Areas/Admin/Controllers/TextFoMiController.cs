using System;
using Microsoft.AspNetCore.Mvc;
using MyTravels.Domain;
using MyTravels.Domain.Entities;
using MyTravels.Service;

namespace MyTravels.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TextFoMiController : Controller
    {
        private readonly DataManager dataManager;
        public TextFoMiController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Edit(string codeWord)
        {
            var entity = dataManager.TextFoMi.GetTextFoMiByCodeWord(codeWord);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(TextFoMi model)
        {
            if (ModelState.IsValid)
            {
                dataManager.TextFoMi.SaveTextFoMi(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
    }
}