using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyTravels.Domain.Entities;
using MyTravels.Domain.Repositories.Abstract;

namespace MyTravels.Domain.Repositories.EntityFramework
{
    public class EFTextFoMiRepository : ITextFoMiRepository
    {
        private readonly AppDbContext context;
        public  EFTextFoMiRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<TextFoMi> GetTextFoMi()
        {
            return context.TextFoMis;
        }
        public TextFoMi GetTextFoMiById(Guid id)
        {
            return context.TextFoMis.FirstOrDefault(x => x.Id == id);
        }

        public TextFoMi GetTextFoMiByCodeWord(string codeWord)
        {
            return context.TextFoMis.FirstOrDefault(x => x.CodeWord == codeWord);
        }

        public void SaveTextFoMi(TextFoMi entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteTextFoMi(Guid id)
        {
            context.TextFoMis.Remove(new TextFoMi() { Id = id });
            context.SaveChanges();
        }
    }
}
