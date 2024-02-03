using GameStoreManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStoreManagement.Server.Configurations.Entities
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
                       new Staff
                       {
                           Id = 1,
                           Name = "Edward Williams",
                           NRIC = "K2456345T",
                           DOB = new DateTime(2002, 7, 23),
                           Email = "emily@gmail.com",
                           ContactNumber = "96750134",
                           Address = "New York",
                           DateCreated = DateTime.Now,
                           DateUpdated = DateTime.Now,
                           Createdby = "System",
                           Updatedby = "System"
                       },
                       new Staff
                       {
                           Id = 2,
                           Name = "Dave Jonas",
                           NRIC = "T7458445J",
                           DOB = new DateTime(1981, 6, 26),
                           Email = "jamie.dornan@gmail.com",
                           ContactNumber = "80850134",
                           Address = "Boston",
                           DateCreated = DateTime.Now,
                           DateUpdated = DateTime.Now,
                           Createdby = "System",
                           Updatedby = "System"
                       }
               );
        }
    }
}
