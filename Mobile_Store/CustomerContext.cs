using System;
using System.Data.Entity;
using System.Linq;

namespace Mobile_Store
{
    class CustomerContext : DbContext
    {

        public CustomerContext()
            : base("name=mobilesdb")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerProduct> CustomerProducts { get; set; }
    }

    }
