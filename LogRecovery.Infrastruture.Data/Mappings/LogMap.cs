using LogRecovery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LogRecovery.Infrastruture.Data.Mappings
{
    public class LogMap : IEntityTypeConfiguration<Log>
    {
        public void Configure(EntityTypeBuilder<Log> builder)
        {
            builder.Property(x => x.Id).IsRequired();

            builder.Property(x => x.Ip).HasMaxLength(15).IsRequired();

            builder.Property(x => x.RecordedTime).IsRequired();

            builder.Property(x => x.DateCreated).IsRequired();

            builder.Property(x => x.UserAgent).HasMaxLength(100).IsRequired();
        }
    }
}
