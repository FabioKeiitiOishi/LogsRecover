using LogRecovery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Metadata;
using LogRecovery.Domain.Models;

namespace LogRecovery.Infrastruture.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder ApplyGlobalConfigurations(this ModelBuilder modelBuilder)
        {
            foreach (IMutableEntityType entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (IMutableProperty property in entityType.GetProperties())
                {
                    switch (property.Name)
                    {
                        case nameof(Entity.Id):
                            property.IsKey();
                            break;
                        case nameof(Entity.DateUpdated):
                            property.IsNullable = true;
                            break;
                        case nameof(Entity.DateCreated):
                            property.IsNullable = false;
                            property.SetDefaultValue(DateTime.Now);
                            break;
                        case nameof(Entity.Deleted):
                            property.IsNullable = false;
                            property.SetDefaultValue(false);
                            break;
                        default:
                            break;
                    }
                }
            }
            return modelBuilder;
        }

        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<Log>()
                .HasData(
                    new Log 
                    { 
                        Id = 1, 
                        Ip = "192.168.0.1", 
                        RecordedTime = new DateTime(2020, 07, 26), 
                        UserAgent = "GET HTTP 1.0", 
                        DateCreated = new DateTime(2020, 02, 05), 
                        DateUpdated = null, 
                        Deleted = false 
                    }
                ); 
            return builder;
        }
    }
}
