using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eshop.Models
{
    public class Basket_Product
    {
        [Key]
        public int id { get; set; }

        [MaxLength(15)]
        public string Name { get; set; }
    }
}