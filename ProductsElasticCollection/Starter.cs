
namespace ProductsElasticCollection
{
    public partial class Starter
    {
        public void Run() 
        {
            
            DisplayProducts display = new DisplayProducts();


            display.AddProduct(new Product() { Id = 1, Name = "Dell Xps", Quantity = 30, Price = 1500, Category = "PCs", OrderCount = 6000 });
            display.AddProduct(new Product() { Id = 2, Name = "Ergonomic Chair", Quantity = 400, Price = 280, Category = "Chairs", OrderCount = 4000 });
            display.AddProduct(new Product() { Id = 3, Name = "Table", Quantity = 500, Price = 250, Category = "Tables", OrderCount = 3000 });


            string[] properties = display.UserInputMethod().Split(',');
            display.ListProducts(properties);
        }
    }
}
