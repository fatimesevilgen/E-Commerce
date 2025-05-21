using System.ComponentModel.DataAnnotations;

namespace E_CommerceCore.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Adı")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Açıklama")]
        public string? Description { get; set; }

        [Display(Name = "Resim")]
        public string? Image { get; set; }

        [Display(Name = "Fiyat")]
        public decimal Price { get; set; }

        [Display(Name = "Ürün Kodu")]
        public string? ProductCode { get; set; }

        [Display(Name = "Stok Adedi")]
        public int Stock { get; set; }

        [Display(Name = "Aktif Mi?")]
        public bool IsActive { get; set; }

        [Display(Name = "Ana Sayfada Gösterilsin Mi?")]
        public bool IsHome { get; set; }

        [Display(Name = "Kategori Id")]
        public int? CategoryId { get; set; }

        public Category? Category { get; set; }

        [Display(Name = "Marka Id")]
        public int? BrandId { get; set; }

        public Brand? Brand { get; set; }

        [Display(Name = "Sıra No")]
        public int OrderNo { get; set; }

        [Display(Name = "Kayıt Tarihi"), ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
