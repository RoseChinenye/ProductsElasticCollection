using ProductsElasticCollection.Data;
using ProductsElasticCollection.@interface;
using System.Dynamic;

namespace ProductsElasticCollection.implementation
{
    internal class DisplayProducts : IProducts
    {
        public void ListProducts(string[] properties)
        {
            DataStore data = new DataStore();

            Console.WriteLine($"\n------------Product list based on the property specified------------\n");
            foreach (Product p in data.products)
            {
                dynamic productProperty = new ExpandoObject();

                productProperty.Id = p.Id;
                productProperty.Name = p.Name;

                productProperty.Quantity = p.Quantity;
                productProperty.Price = p.Price;

                productProperty.Category = p.Category;
                productProperty.OrderCount = p.OrderCount;

                foreach (string property in properties)
                {
                    switch (property)
                    {

                        case "id":
                            Console.Write($"  {productProperty.Id},");
                            break;

                        case "name":
                            Console.Write($"  {productProperty.Name},");
                            break;

                        case "quantity":
                            Console.Write($"  {productProperty.Quantity},");
                            break;

                        case "price":
                            Console.Write($"  ${productProperty.Price},");
                            break;

                        case "category":
                            Console.Write($"  {productProperty.Category},");
                            break;

                        case "ordercount":
                            Console.Write($"  {productProperty.OrderCount},");
                            break;

                        default:
                            Console.Clear();

                            Console.WriteLine("\n Properties doesn't exist, please enter property to display separated by comas (,)!");
                            GetUserInput();
                            break;
                    }
                }
                Console.WriteLine("\n");

            }
        }

        public void showProducts()
        {
            DataStore data = new DataStore();

            foreach (Product p in data.products)
            {
                Console.WriteLine($" ID: {p.Id},\t Name: {p.Name},\t Quantity: {p.Quantity},\t Price: ${p.Price},\t Category: {p.Category},\t OrderCount: {p.OrderCount}\t");
            }
        }

        public string GetUserInput()
        {
            showProducts();

            Console.Write("\n Specify what property to display. If property is more than one, separate them with comas(,)  \n\n  ");

            string input = Console.ReadLine().ToLower().Replace(" ", "");
            
            return input;
            
        }
    }
}
