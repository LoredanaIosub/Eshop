using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Eshop.Models
{
    public class Category
    {
        [Key]//pt a se sti ca este cheie primara
        public int Id_Category { get; set; }//metoda

        [Required]
        [MaxLength(35)]
        public string Name { get; set; }

    }
}