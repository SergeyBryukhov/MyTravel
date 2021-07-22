using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyTravels.Domain;

namespace MyTravels.Models.ViewComponents
{
    public class SidebarViewComponent : ViewComponent
    {
        private readonly DataManager dataManager;

        public SidebarViewComponent(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult((IViewComponentResult) View("Default", dataManager.HistoryTravel.GetHistoryTravels()));
        }
    }
}
