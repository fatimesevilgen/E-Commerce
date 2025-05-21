using System.ComponentModel.DataAnnotations;

namespace E_CommerceCore.Entities
{
    public class Contact : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Adı")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Soyadı")]
        public string Surname { get; set; } = string.Empty;

        public string? Email { get; set; }

        [Display(Name = "Telefon")]
        public string? Phone { get; set; }

        [Display(Name = "Mesaj")]
        public string Message { get; set; } = string.Empty;

        [Display(Name = "Kayıt Tarihi"), ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
