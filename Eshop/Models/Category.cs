using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eshop.Models
{
    public class Category
    {
        //private Category _category;

        //public string Name { get; set; } //metoda
        //public Category category { get => _category; set => _category = value; } //aducem informatia din clasa Category

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ItemId { get; set; }
        //public List<Item> Items { get; set; }
    }
}