using System.ComponentModel.DataAnnotations;

namespace E_CommerceCore.Entities
{
    public class Brand : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Ad")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Açıklama")]
        public string Description { get; set; } = string.Empty;

        [Display(Name = "Logo")]
        public string? Logo { get; set; }

        [Display(Name = "Aktif Mi?")]
        public bool IsActive { get; set; }

        [Display(Name = "Sıra No")]
        public int OrderNo { get; set; }

        [Display(Name = "Kayıt Tarihi"), ScaffoldColumn(false)]
        public DateTime DateTime { get; set; } = DateTime.Now;
        public IList<Product>? Products { get; set; }
    }
}
