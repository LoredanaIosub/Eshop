using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Eshop.Models
{
    public class Basket
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(15)]
        public bool Condition { get; set; }

        public DateTime Update_Data { get; set; }

        public decimal Total_Price { get; set; }


    }
}