using System;
using System.Linq;
using MyTravels.Domain.Entities;


namespace MyTravels.Domain.Repositories.Abstract
{
    public interface ITextFoMiRepository
    {
        IQueryable<TextFoMi> GetTextFoMi();
        TextFoMi GetTextFoMiById(Guid id);
        TextFoMi GetTextFoMiByCodeWord(string codeWord);
        void SaveTextFoMi(TextFoMi entity);
        void DeleteTextFoMi(Guid id);
    }
}
