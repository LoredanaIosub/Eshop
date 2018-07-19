﻿using System;
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

        //public DbSet<Category> Categories { get; set; }
        //public DbSet<Item> Items { get; set; }
        //public DbSet<Basket> Baskets { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        //public DbSet<Basket_Product> Basket_Products { get; set; }

        //protected override void onmodelcreating(dbmodelbuilder modelbuilder)
        //{
        //    var one = modelbuilder.entity<category>();
        //    one.totable("category");

        //    one.haskey(d => new
        //    {
        //        d.oneid,
        //        d.twoid,
        //        d.threeid
        //    });

        //    one.property(d => d.oneid)
        //        .hasdatabasegeneratedoption(databasegeneratedoption.none);

        //    one.hasrequired(t => t.two)
        //        .withmany(s => s.ones)
        //        .hasforeignkey(t => t.twoid);

        //    one.hasrequired(t => t.three)
        //        .withmany(s => s.ones)
        //        .hasforeignkey(t => t.threeid);

        //    var two = modelbuilder.entity<two>();
        //    two.totable("two");

        //    two.haskey(d => new
        //    {
        //        d.twoid,
        //        d.threeid
        //    });

        //    two.property(p => p.twoid)
        //        .hasdatabasegeneratedoption(databasegeneratedoption.none);

        //    two.hasrequired(t => t.three)
        //        .withmany(s => s.twos)
        //        .hasforeignkey(t => t.threeid);

        //    var three = modelbuilder.entity<three>();
        //    three.totable("three");
        //    three.haskey(s => s.threeid);

        //    three.property(p => p.threeid)
        //        .hasdatabasegeneratedoption(databasegeneratedoption.none);

        //    base.onmodelcreating(modelbuilder);
        //}





    }

}


