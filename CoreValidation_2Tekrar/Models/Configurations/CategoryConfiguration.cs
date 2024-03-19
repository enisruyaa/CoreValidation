using CoreValidation_2Tekrar.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreValidation_2Tekrar.Models.Configurations
{
    public class CategoryConfiguration : BaseConfiguration<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.CategoryName).HasMaxLength(20);
        }
    }
}
