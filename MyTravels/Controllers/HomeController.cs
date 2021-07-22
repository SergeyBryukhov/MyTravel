using Microsoft.AspNetCore.Mvc;
using MyTravels.Domain;

namespace MyTravels.Controllers
{

    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(dataManager.TextFoMi.GetTextFoMiByCodeWord("PageIndex"));
        }
        public IActionResult UseInfo()
        {
            return View(dataManager.TextFoMi.GetTextFoMiByCodeWord("PageUsefulinfo"));
        }
        public IActionResult Contacts()
        {
            return View(dataManager.TextFoMi.GetTextFoMiByCodeWord("PageContacts"));
        }
    }
}
