using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class entitystore:DbContext
    {
        public entitystore() : base("name=mobilesdb")
        {
        }
        public DbSet<mobildetaile> mobdetailes { get; set; }
        public DbSet<mobile_images> mobimages { get; set; }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<mobildetaile>()
        //        .HasOptional(a => a.Mobile_Images).WithRequired(ab => ab.Mobildetaile).Has
        //}
    }
}
