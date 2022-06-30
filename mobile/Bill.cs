using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobile
{
    public class Bill
    {
  
        public int Id { get; set; }
       
        public string ProductName { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public int Discount { get; set; }
       

    }
}
