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
    
    }
}
