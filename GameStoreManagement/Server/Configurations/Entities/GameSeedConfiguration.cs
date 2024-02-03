using Microsoft.EntityFrameworkCore;
using GameStoreManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Drawing;



namespace GameStoreManagement.Server.Configurations.Entities
{
    public class GameSeedConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasData(
                    new Game
                    {
                        Id = 1,
                        Name = "Call of Duty",
                        Platform = "Play Station",
                        ReleaseDate = new DateTime(2009, 2, 23),
                        Price = 49.9,
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        Createdby = "System",
                        Updatedby = "System"
                    },
                    new Game
                    {
                        Id = 2,
                        Name = "Need for Speed",
                        Platform = "X-box",
                        Price = 39.9,
                        ReleaseDate = new DateTime(2001, 5, 30),
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        Createdby = "System",
                        Updatedby = "System"
                    }
            );
        }
    }


}
