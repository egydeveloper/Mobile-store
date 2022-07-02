using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
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
    
    }
}
