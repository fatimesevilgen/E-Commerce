using System.ComponentModel.DataAnnotations;

namespace E_CommerceCore.Entities
{
    public class Category : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Adı")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Açıklama")]
        public string? Description { get; set; }

        [Display(Name = "Resim")]
        public string? Image { get; set; }

        [Display(Name = "Aktif Mi?")]
        public bool IsActive { get; set; }

        [Display(Name = "Üst Menüde Mi?")]
        public bool IsTopMenu { get; set; }

        [Display(Name = "Üst Kategori Id")]
        public int ParentId { get; set; }

        [Display(Name = "Sıra No")]
        public int OrderNo { get; set; }

        [Display(Name = "Kayıt Tarihi"), ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public IList<Product>? Products { get; set; }
    }
}
