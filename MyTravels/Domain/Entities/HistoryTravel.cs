using System.ComponentModel.DataAnnotations;

namespace MyTravels.Domain.Entities
{
    public class HistoryTravel : EntityBase
    {
        [Required(ErrorMessage = "Заполните название путешествие")]
        [Display(Name = "Тема путешествия")]
        public override string Title { get; set; }

        [Display(Name = "Краткое описание путешествия")]
        public override string Subtitle { get; set; }

        [Display(Name = "Полное описание путешествия")]
        public override string Text { get; set; }
    }
}
