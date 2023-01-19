using ProductsElasticCollection.implementation;

namespace ProductsElasticCollection.UI
{
    public class Starter
    {
        public void Run()
        {
            DisplayProducts display = new DisplayProducts();

        Start: try
            {
                Console.WriteLine("------------This App Displays Products!-------------");
                Console.WriteLine("Enter 1, 2 or 3\n1: Display all Products info\n2: Display Specified Product info\n3: Exit \n");

                var selection = Console.ReadLine();
                if (int.TryParse(selection, out int option))

                    switch (option)
                    {
                        case 1:
                            display.showProducts();
                            goto Start;
                        case 2:
                            string[] properties = display.GetUserInput().Split(',');
                            display.ListProducts(properties);
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }



        }
    }
}
