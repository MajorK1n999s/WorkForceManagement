using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WFM.Domain.Entities;

namespace WFM.Infrastructure.Persistence.Configurations
{
    public class EmployeeContactConfiguration : IEntityTypeConfiguration<EmployeeContact>
    {
        public void Configure(EntityTypeBuilder<EmployeeContact> builder) 
        {
            builder.ToTable("EmployeeContacts");

            builder.HasKey(ec => ec.Id);

            builder.Property(ec => ec.MobileNumber)
                .HasMaxLength(20);

            builder.Property(ec => ec.Email)
                .HasMaxLength(150);
        }
    }
}
