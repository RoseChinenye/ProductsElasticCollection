using System.Dynamic;

namespace ProductsElasticCollection
{
    internal class DisplayProducts
    {
        public DisplayProducts()
        {

        }

        private List<Product> products = new List<Product>();
       
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void ListProducts(string[] properties = null)
        {

            Console.WriteLine("\n------------Product list------------\n");
            foreach (Product p in products)
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
                        case "" and "" and "" and "" and "" and "":
                            Console.WriteLine($"  {productProperty.Id}, {productProperty.Name}, {productProperty.Quantity}, {productProperty.Price}, {productProperty.Category}, {productProperty.OrderCount}");
                            break;

                        case "Id":
                            Console.Write($"  {productProperty.Id},");
                            break;

                        case "Name":
                            Console.Write($"  {productProperty.Name},");
                            break;

                        case "Quantity":
                            Console.Write($"  {productProperty.Quantity},");
                            break;

                        case "Price":
                            Console.Write($"  ${productProperty.Price},");
                            break;

                        case "Category":
                            Console.Write($"  {productProperty.Category},");
                            break;

                        case "OrderCount":
                            Console.Write($"  {productProperty.OrderCount},");
                            break;

                        default:
                            Console.Clear();

                            Console.WriteLine("\n  Invalid Properties entered,try again!");
                            UserInputMethod();
                            break;
                    }
                }
                Console.WriteLine("\n");

            }
        }

        public string UserInputMethod()
        {
            
            Console.Write("\n  Enter properties to display (Use comma to seperate if many properties): \n\n  ");

            string input = Console.ReadLine().Replace(" ", "");

            return input;
        }
    }
}
