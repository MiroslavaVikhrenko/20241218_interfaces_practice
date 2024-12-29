namespace _20241229_task21
{
    internal class Program
    {
        /*
         Описать класс «User», со свойствами: Имя и Возраст. 
        Создать массив на 8 пользователей. Используя метод расширения, получить самого старшего пользователя.
         */
        static void Main(string[] args)
        {
            User[] users =
            {
                new User("Kate", 30),
                new User("Erik", 45),
                new User("Barbara", 50),
                new User("David", 23),
                new User("Tyler", 69),
                new User("Maria", 80),
                new User("Makoto", 37),
                new User("Ravi", 46)
            };

            Console.WriteLine("----------All users----------\n");
            PrintArray(users);

            Console.WriteLine("\n----------The oldest user----------\n");
            Console.WriteLine(users.FindOldest());

            Console.ReadKey();
        }

        public static void PrintArray(User[] users)
        {
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine(users[i]);
            }
        }
    }

    public static class Extensions
    {
        public static User FindOldest(this User[] users)
        {
            Array.Sort(users);
            return users[0];
        }
    }

    public class User : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name} {Age} y.o.";
        }
        public int CompareTo(object? obj)
        {
            User u = obj as User;
            if (u != null)
            {
                return u.Age.CompareTo(Age);
            }
            else
            {
                throw new Exception("Unable to compare objects");
            }
        }
    }
}
