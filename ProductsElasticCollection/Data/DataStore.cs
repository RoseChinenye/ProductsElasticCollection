using ProductsElasticCollection.implementation;

namespace ProductsElasticCollection.Data
{
    internal class DataStore
    {
        public List<Product> products = new List<Product> {

         new Product() { Id = 1, Name = "Dell Xps", Quantity = 30, Price = 1500, Category = "PCs", OrderCount = 6000 },
         new Product() { Id = 2, Name = "Ergonomic Chair", Quantity = 400, Price = 280, Category = "Chairs", OrderCount = 4000 },
         new Product() { Id = 3, Name = "Table", Quantity = 500, Price = 250, Category = "Tables", OrderCount = 3000 }

         };
    }
}

