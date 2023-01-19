
namespace ProductsElasticCollection
{
    public class Starter
    {
        public void Run() 
        {
            
            DisplayProducts display = new DisplayProducts();

            string[] properties = display.UserInputMethod().Split(',');
            display.ListProducts(properties);
        }
    }
}
