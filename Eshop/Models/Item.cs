using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eshop.Models
{
    public class Item
    {

        

        public int ItemId { get; set; } //metoda
        public int CategoryId { get; set; }
        public int ProducerIdId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string ItemUrl { get; set; }
        public Category category { get; set; }
        public Producer producer { get; set; }
        public Item item { get; set; }
        

    }
        
        
}