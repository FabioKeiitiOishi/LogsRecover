using LogRecovery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace LogRecovery.Infrastruture.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<Log>()
                .HasData(
                    new Log { Id = 1, Ip = "192.168.0.1", RecordedTime = DateTime.Now, UserAgent = "GET HTTP 1.0" }
                ); 
            return builder;
        }
    }
}
