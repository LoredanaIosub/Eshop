using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Eshop.Models
{
    public class Categories
    {
        [Key]
        public int id { get; set; }

        [MaxLength(15)]
        public string Name { get; set; }

    }
}