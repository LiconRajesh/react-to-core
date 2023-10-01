using Core_To_React_Api.Core.ProjectAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core_To_React_Api.Infrastructure.Data.Config
{
    public class ToDoConfiguration : IEntityTypeConfiguration<ToDoItem>
    {
        public void Configure(EntityTypeBuilder<ToDoItem> builder)
        {
            builder.Property(t => t.Title)
                .IsRequired();
        }
    }
}
