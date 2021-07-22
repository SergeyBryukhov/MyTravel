using MyTravels.Domain.Repositories.Abstract;

namespace MyTravels.Domain
{
    public class DataManager
    {
        public ITextFoMiRepository TextFoMi { get; set; }
        public IHistoryTravelRepository HistoryTravel { get; set; }

        public DataManager(ITextFoMiRepository textFoMiRepository, IHistoryTravelRepository historyTravelRepository)
        {
            TextFoMi = textFoMiRepository;
            HistoryTravel = historyTravelRepository;
        }
    }
}
