using E_CommerceCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_CommerceData.Configuration
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(x => x.SurName).IsRequired().HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(x => x.PhoneNumber).HasColumnType("varchar(15)").HasMaxLength(15);
            builder.Property(x => x.Password).IsRequired().HasColumnType("nvarchar(50)").HasMaxLength(50);
            builder.Property(x => x.UserName).HasColumnType("varchar(50)").HasMaxLength(50);
            builder.HasData(  //eğer böyle bir kullanıcı yoksa oluştur. (Admin oluşturma)
                new AppUser
                {
                    Id = 1,
                    UserName = "Admin",
                    Email = "admin@admin.com",
                    IsActive = true,
                    IsAdmin = true,
                    Name = "Admin",
                    Password = "123456*",
                    SurName = "User"
                });
        }
    }
}
