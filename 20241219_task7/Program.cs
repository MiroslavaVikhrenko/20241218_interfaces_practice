namespace _20241219_task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products =
{
                new Product {Name = "table", Price = 100.0m},
                new Product {Name = "sofa", Price = 150.0m},
                new Product {Name = "chair", Price = 50.0m},
                new Product {Name = "cabinet", Price = 170.0m},
                new Product {Name = "bed", Price = 200.0m},
                new Product {Name = "shelf", Price = 30.0m},
                new Product {Name = "plant pot", Price = 15.0m},
                new Product {Name = "armchair", Price = 80.0m},
                new Product {Name = "refrigerator", Price = 500.0m},
                new Product {Name = "microwave", Price = 130.0m}
            };

            Console.WriteLine("--------------------Original Array--------------------\n");
            PrintArray(products);

            Array.Sort(products);

            Console.WriteLine("\n\n--------------------Sorted by Price--------------------\n");
            PrintArray(products);

            Console.ReadKey();
        }
        public static void PrintArray(Product[] products)
        {
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i]}");
            }
        }
    }
}
