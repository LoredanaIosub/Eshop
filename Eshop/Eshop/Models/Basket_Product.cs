using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Eshop.Models
{
    public class Basket_Product
    {
        [Key]
        public int Id_Basket { set; get; }

        public int Quantity { set; get; }

        public bool Stock { set; get; }
    }
}