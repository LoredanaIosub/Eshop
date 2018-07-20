
using System.Data.Entity;

namespace Eshop.Models
{
    public class ShoppingStoreDBInitializer : CreateDatabaseIfNotExists<ShoppingStoreDB>
    {
        protected override void Seed(ShoppingStoreDB context)
        {
            Category category = new Category()
            {
                Id = 0,
                Name = "Categorie"
            };

            Item item = new Item()
            {
                Id = 1,
                Name = "Produs",
                Description = "Descriere",
                Price = 10,
                Producer = "Producator",
                Id_Category = 0
            };

            Basket basket = new Basket()
            {
                Id = 0,
                Condition =true,
                Total_Price = 15
            };
        }


    }
}