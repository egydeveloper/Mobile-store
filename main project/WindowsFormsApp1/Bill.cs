using main;
using Mobile_Store;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace mobile
{
    public class Bill
    {
  
        public int Id { get; set; }
       
        public string ProductName { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public int Discount { get; set; }
        public virtual ICollection<mobildetaile> Mobildetailes { get; set; }
        public Customer Customer { get; set; }
        public virtual ICollection<accessierdetaile> Accessierdetailes { get; set; }



    }
}
