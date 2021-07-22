using System;
using System.Linq;
using MyTravels.Domain.Entities;


namespace MyTravels.Domain.Repositories.Abstract
{
    public interface IHistoryTravelRepository
    {
        IQueryable<HistoryTravel> GetHistoryTravels();
        HistoryTravel GetHistoryTravelById(Guid id);
        void SaveHistoryTravel(HistoryTravel entity);
        void DeleteHistoryTravel(Guid id);
    }
}
