using System.ComponentModel.DataAnnotations;

namespace E_CommerceCore.Entities
{
    public class AppUser : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Adı")]
        public string Name { get; set; }
        [Display(Name = "Soyadı")]
        public string SurName { get; set; }
        public string Email { get; set; }
        [Display(Name = "Telefon")]
        public string? PhoneNumber { get; set; }  //zorunlu olmayan alanlar için ? eklenebilir
        [Display(Name = "Şifre")]
        public string Password { get; set; }
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; } = string.Empty;
        [Display(Name = "Aktif Mi?")]
        public bool IsActive {  get; set; }
        [Display(Name = "Admin Mi?")]
        public bool IsAdmin { get; set; }
        [ScaffoldColumn(false)] // oluşacak iskelet sayfalarında bu alan kullanılmaz
        public Guid? UserGuid { get; set; }
        [Display(Name = "Kayıt Tarihi"), ScaffoldColumn(false)]
        public DateTime CreatDate { get; set; } = DateTime.Now;
    }
}
