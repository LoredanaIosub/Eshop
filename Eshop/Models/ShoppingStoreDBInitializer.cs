
using System.Collections.Generic;
using System.Data.Entity;

namespace Eshop.Models
{
    public class ShoppingStoreDBInitializer : CreateDatabaseIfNotExists<ShoppingStoreDB>
    {
        protected override void Seed(ShoppingStoreDB context)
        {
            Category category = new Category()
            {
                Id_Category = 0,
                Name = "Categorie"
            };

            var categories = new List<Category>();
            categories.Add(category);

            Item item = new Item()
            {
                Id_Item = 0,
                Name = "Produs",
                Description = "Descriere",
                Price = 10,
                Producer = "Producator",
                Categories = categories
            };

            Basket basket = new Basket()
            {
                Id_Basket = 0,
                Condition = "Conditie",
                Total_Price = 15
            };
        }


    }
}