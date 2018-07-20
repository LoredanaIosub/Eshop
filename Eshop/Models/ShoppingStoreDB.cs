using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Eshop.Models
{ 

    public class ShoppingStoreDB : DbContext //mostenire
    {
        public ShoppingStoreDB() : base("Eshop")
        {
            //Disable initializer
            Database.SetInitializer<ShoppingStoreDB>(new CreateDatabaseIfNotExists<ShoppingStoreDB>());
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Basket_Product> Basket_Products { get; set; }
        public DbSet<Command> Commands { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public object ContactModels { get; internal set; }
    }

}


