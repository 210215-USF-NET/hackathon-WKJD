using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCVModels;

namespace VCVDL
{
    public class VCVDBContext : DbContext
    {
        public VCVDBContext(DbContextOptions options) : base(options)
        {

        }
        protected VCVDBContext()
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Image> Images { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(user => user.UserID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Image>()
                .Property(image => image.ImageID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<User>()
                .HasMany(i => i.Images)
                .WithOne(u => u.User)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }

}
