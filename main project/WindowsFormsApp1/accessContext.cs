using mobile;
using Mobile_Store;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace main
{
    class accessContext:DbContext
    {
        public accessContext() : base("name=mobilesdbs")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure Student & StudentAddress entity
            modelBuilder.Entity<accessierdetaile>()
                        .HasOptional(s => s.Accessierimages) // Mark Address property optional in Student entity
                        .WithRequired(ad => ad.Accessierdetaile);
        }
        public DbSet<accessierdetaile> accdetailes { get; set; }
        public DbSet<accessierimages> accimages { get; set; }
       
        public DbSet<mobildetaile> mobdetailes { get; set; }
        public DbSet<mobile_images> mobimages { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerProduct> CustomerProducts { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }

    }
}
