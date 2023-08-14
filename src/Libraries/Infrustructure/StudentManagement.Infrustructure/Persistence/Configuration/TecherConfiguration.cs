using Microsoft.EntityFrameworkCore;
using StudentManagement.Model;
using StudentManagement.Shared.Enum;

namespace StudentManagement.Infrustructure.Persistence.Configuration;

public class TecherConfiguration : IEntityTypeConfiguration<Teacher>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Teacher> builder)
    {
        builder.ToTable("Teacher");
        builder.HasKey(t => t.Id);
        builder.HasData(new
        {
            Id = 1,
            TeacherName = "Santanu",
            Salary = 40000.00,
            Department="IT",
            Created=DateTimeOffset.Now,
            CreatedBy="1",
            Stutus= EntityStatus.Created

        });
    }
}
