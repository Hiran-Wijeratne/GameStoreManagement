using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GameStoreManagement.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration :
    IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "bb62918a-8c56-45a5-b49e-e2588087cb51",
                UserId = "6c82afae-e1c9-4152-b11d-8d88ec4119a8"
            },
            new IdentityUserRole<string>
            {
                RoleId = "8a40ea54-6974-4fe5-bd15-26a8f8e03d65",
                UserId = "e2b379a5-eaf2-454a-bf60-b83f93d8b461"
            }
            );
        }
    }
}