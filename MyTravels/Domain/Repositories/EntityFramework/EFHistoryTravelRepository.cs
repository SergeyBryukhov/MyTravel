using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyTravels.Domain.Entities;
using MyTravels.Domain.Repositories.Abstract;


namespace MyTravels.Domain.Repositories.EntityFramework
{
    public class EFHistoryTravelRepository : IHistoryTravelRepository
    {
        private readonly AppDbContext context;
        public EFHistoryTravelRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<HistoryTravel> GetHistoryTravels()
        {
            return context.HistoryTravels;
        }

        public HistoryTravel GetHistoryTravelById(Guid id)
        {
            return context.HistoryTravels.FirstOrDefault(x => x.Id == id);
        }

        public void SaveHistoryTravel(HistoryTravel entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteHistoryTravel(Guid id)
        {
            context.HistoryTravels.Remove(new HistoryTravel() { Id = id });
            context.SaveChanges();
        }
    }
}
