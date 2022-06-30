using System;
using System.Data.Entity;
using System.Linq;

namespace mobile
{
    public class MobileContext : DbContext
    {
      
        public MobileContext()
            : base("name=mobilesdb")
        {
        }

        
         public virtual DbSet<Bill> Bills { get; set; }
    }

  
}