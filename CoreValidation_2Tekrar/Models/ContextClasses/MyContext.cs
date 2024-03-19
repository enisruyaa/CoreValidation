using CoreValidation_2Tekrar.Models.Configurations;
using CoreValidation_2Tekrar.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreValidation_2Tekrar.Models.ContextClasses
{
    public class MyContext :DbContext
    {
        public MyContext(DbContextOptions<MyContext> opt) :base (opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        }

        public DbSet<Category> Categories { get; set; }
    }
}
