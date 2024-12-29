using System.Xml.Schema;

namespace _20241228_task17
{
    internal class Program
    {
        /*
         Создайте систему управления библиотекой, в которой будут различные типы медиаматериалов 
        (книги, журналы, DVD и т.д.), каждый из которых реализует интерфейс IMediaItem. 
        Добавьте функциональность для добавления, удаления и поиска медиаматериалов в библиотеке. 
        Также реализуйте интерфейсы для материалов, которые могут быть арендованы или возвращены.

        1) Интерфейс IMediaItem: Должен содержать свойства Title (название), 
        Author (автор) и Year (год выпуска). Должен содержать метод DisplayInfo(), 
        который выводит информацию о медиаматериале.
        2) Интерфейс IBorrowable: Должен содержать метод Borrow(), 
        который будет арендовать медиаматериал. Должен содержать метод Return(), 
        который будет возвращать медиаматериал.
        3) Классы Book, Magazine, DVD: Реализуют интерфейс IMediaItem. Классы Book и DVD также реализуют интерфейс IBorrowable.
        4) Класс Library: Управляет коллекцией медиаматериалов. Может добавлять медиаматериалы в библиотеку, удалять их и искать по названию.
         */
        static void Main(string[] args)
        {
            Library library = new Library();
            library.AddResource(new Book("Snow Country", "Kawabata Yasunari", new DateTime(1948, 01, 01)));
            library.AddResource(new Book("Kinkakuji", "Mishima Yukio", new DateTime(1956, 01, 01)));
            library.AddResource(new Book("The Strange Work", "Oe Kenzaburo", new DateTime(1957, 01, 01)));
            library.AddResource(new Book("Leap Before You Look", "Oe Kenzaburo", new DateTime(1958, 01, 01)));
            library.AddResource(new Magazine("Nipponia", "Japan Foundation", new DateTime(2006, 01, 01)));
            library.AddResource(new Magazine("Kabuki", "Kabuki Foundation", new DateTime(2010, 01, 01)));
            library.AddResource(new DVD("One Wonderful Sunday", "Akira Kurosawa", new DateTime(1947, 01, 01)));
            library.AddResource(new DVD("Stray Dog", "Akira Kurosawa", new DateTime(1949, 01, 01)));
            library.AddResource(new DVD("Rashomon", "Akira Kurosawa", new DateTime(1950, 01, 01)));


            library.DisplayLibraryInfo();

            DVD dvd = new DVD("Seven Samurai", "Akira Kurosawa", new DateTime(1954, 01, 01));
            library.AddResource(dvd);
            Console.ReadKey();
            Console.Clear();


            library.DisplayLibraryInfo();
            Console.WriteLine("--------------\nEnter a title for search");
            string search = Console.ReadLine();
            library.SearchByTitle(search);

            Console.WriteLine("--------------\nEnter a title for deletion");
            string delete = Console.ReadLine();
            library.RemoveResource(delete);
            Console.ReadKey();            

            while (true)
            {
                Console.Clear();
                library.DisplayLibraryInfo();

                Console.WriteLine("--------------\nDo you want to return or to borrow?\n1. Borrow\n2. Return\n3. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("--------------\nEnter a title for borrowing");
                        string borrow = Console.ReadLine();

                        bool exist = false;

                        foreach (var item in library.Catalog.ToList())
                        {
                            if (item.Title == borrow)
                            {
                                if (item is Magazine)
                                {
                                    Console.WriteLine("You cannot borrow magazines, please read in the library");
                                    continue;
                                }

                                IBorrowable borrowable = (IBorrowable)item;

                                borrowable.Borrow(library);
                                exist = true;
                            }
                        }

                        if (!exist)
                        {
                            Console.WriteLine("There is no such resource in catalog");
                        }
                        Console.ReadKey();
                    break;
                    case 2:
                        Console.WriteLine("--------------\nEnter a title for returning");
                        string returning = Console.ReadLine();

                        bool exist2 = false;

                        foreach (var item in library.Catalog.ToList())
                        {
                            if (item.Title == returning)
                            {
                                if (item is Magazine)
                                {
                                    Console.WriteLine("You cannot borrow or return magazines");
                                    continue;
                                }

                                IBorrowable borrowable = (IBorrowable)item;

                                borrowable.Return(library);
                                exist2 = true;
                            }
                        }

                        if (!exist2)
                        {
                            Console.WriteLine("There is no such resource in catalog");
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        continue;
                }
                
            }
            



            Console.ReadKey();
        }
    }
}
