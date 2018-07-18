using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Eshop.Models
{
    public class Basket_Product
    {
        [Key]
        [ForeignKey("Basket")]
        public int Id_Basket { set; get; }
        [Key]
        [ForeignKey("Item")]
        public int Id_Product { set; get; }

        public int Quantity { set; get; }

        public bool Stock { set; get; }
    }
}