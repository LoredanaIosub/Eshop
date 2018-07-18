using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Eshop.Models
{ 

    public class ShoppingStoreDB : DbContext //mostenire
    {
        public ShoppingStoreDB() : base("ConnectionString")
        {
            //Disable initializer
            Database.SetInitializer<ShoppingStoreDB>(null);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Basket> Baskets { get; set; }


    }

}


