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
        [Column("Id_Basket", Order=0)]
        public int Id_Basket { get; set; }

        [ForeignKey("Id_Basket")]
        public virtual ICollection<Basket> Baskets { get; set; }
      

        [Key]
        [Column("Id_Item", Order = 1)]
        public int Id_Item { get; set; }

        [ForeignKey("Id_Item")]
        public virtual ICollection<Item> Items { get; set; }

        public int Quantity { set; get; }

        public bool Stock { set; get; }
    }
}