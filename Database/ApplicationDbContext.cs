using E_Commerce_Udemy_Practice.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace E_Commerce_Udemy_Practice.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<User>()
            //    .HasOne(a => a.Address)
            //    .WithOne()
            //    .HasForeignKey<UserAddress>(a => a.Id)
            //    .OnDelete(DeleteBehavior.Cascade);

            //builder.Entity<Role>()
            //.HasData(
            //        new Role { Id = 1, Name = "Member", NormalizedName = "MEMBER" },
            //        new Role { Id = 2, Name = "Admin", NormalizedName = "ADMIN" }
            //    );
        }
    }
}
