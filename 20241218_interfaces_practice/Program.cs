namespace _20241218_interfaces_practice
{
    internal class Program
    {
        /*
         Создать интерфейс «Транспортное средство». 
        Транспортные средства с различными реализациями расчета затраченного топлива: 
        машина, машина-гибрид, вертолет.
         */
        static void Main(string[] args)
        {
            Car c1 = new Car("Toyota", 200, 2);
            Hybrid h1 = new Hybrid("Honda", 180, 1);
            Helicopter he1 = new Helicopter("Airbus", 250, 3);

            ITransport[] transports = { c1, h1, he1 };

            for (int i = 0;  i < transports.Length; i++)
            {
                Console.Clear();
                Console.WriteLine($"Current item:\n{transports[i].ToString()}");

                try
                {
                    Console.WriteLine("Choose:\n1.Calculate fuel by distance\n2.Calculate fuel by hours and speed");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter distance in km:");
                            int distance = Convert.ToInt32(Console.ReadLine());
                            transports[i].CalculateFuelByDistance(distance);
                            break;
                        case 2:
                            Console.WriteLine("Enter hours:");
                            int hours = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter speed in km/h:");
                            int speed = Convert.ToInt32(Console.ReadLine());
                            transports[i].CalculateFuelByTime(hours, speed);
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            Console.ReadKey();
            }
        }
    }
}
