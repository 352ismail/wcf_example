using Products;
using System.Configuration;

namespace Client
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            // Create an instance of the service client
            Products.NorthWindService client = new Products.NorthWindService();

            // Example usage
            Console.WriteLine("Ener A to Show All Data");
            var a = Console.ReadLine();
            if (a == "A")
            {
                List<Product> ListOfProducts = client.GetProducts();
                foreach (var product in ListOfProducts)
                {
                    Console.WriteLine("Products Data");
                    Console.WriteLine(product);

                }
            }
            Console.WriteLine("Ener B to Edit");
            var b = Console.ReadLine();
            if (b == "B")
            {
                Console.WriteLine("Ener Product Id to Edit");
                var Id = Console.ReadLine();
                var Idint = Convert.ToInt32(Id);
                Console.WriteLine("Ener Product Name to Edit");
                var Name = Console.ReadLine();

                Product Products = client.EditProducts(Idint, Name);
                Console.WriteLine(Products);
            }
            Console.WriteLine("Ener C to Get Details");
            var c = Console.ReadLine();
            if (c == "C")
            {
                Console.WriteLine("Ener Product Id to Get details");
                var Id = Console.ReadLine();
                var Idint = Convert.ToInt32(Id);

                Product Products = client.GetProductsDetails(Idint);
                Console.WriteLine(Products);
            }

            Console.ReadLine();
        }
    }
}

