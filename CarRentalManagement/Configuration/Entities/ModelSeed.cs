using CarRentalManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Configuration.Entities
{
    public class ModelSeed : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
                    new Model
                    {
                        Id = 5,
                        Name = "i4",
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    },
                    new Model
                    {
                        Id = 6,
                        Name = "X5",
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    },
                    new Model
                    {
                        Id = 7,
                        Name = "Prius",
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    },
                    new Model
                    {
                        Id = 8,
                        Name = "C-HR",
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    }
                    );

        }
    }
}
