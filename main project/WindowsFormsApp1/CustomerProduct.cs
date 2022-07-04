using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Store
{
     class CustomerProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string ProductName { get; set; }

        [Required]
        public int Quantity { get; set; }
        [Required]
        public int CustomerPhone { get; set; }

        [ForeignKey("Customer")]
        [Required]
        public int Customer_ID { get; set; }
        public Customer Customer { get; set; }

        public virtual ICollection<CustomerProduct> Products { get; set; }
        = new HashSet<CustomerProduct>();
      
    }
}
