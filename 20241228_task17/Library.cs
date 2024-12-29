using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241228_task17
{
    /*
     Класс Library: Управляет коллекцией медиаматериалов. Может добавлять медиаматериалы в библиотеку, удалять их и искать по названию.
     */
    public class Library
    {
        public List<IMediaItem> Catalog { get; set; }
        public List<IBorrowable> AvailableResorces { get; set; }
        public List<IBorrowable> BorrowedResources { get; set; }

        public Library()
        {
            Catalog = new List<IMediaItem>();
            AvailableResorces = new List<IBorrowable>();
            BorrowedResources = new List<IBorrowable>();
        }

        public void SearchByTitle(string title)
        {
            Console.WriteLine($"--------------\nSearching in catalog...");

            int count = 0;
            foreach (var item in Catalog.ToList())
            {
                if (item.Title == title)
                {
                    Console.WriteLine($"Found the following resource:");
                    item.DisplayInfo();
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No results");
            }
        }

        public void AddResource(IMediaItem item)
        {
            Catalog.Add(item);
            if (item is IBorrowable)
            {
                AvailableResorces.Add((IBorrowable)item);
            }
            
            Console.WriteLine($"--------------\n{item.Title} added to catalog");
        }

        public void RemoveResource(string title)
        {
            bool exist = false;
            foreach (var item in Catalog.ToList())
            {
                if (item.Title == title)
                {
                    var itemToDelete = item;
                    Catalog.Remove(itemToDelete);
                    if (itemToDelete is IBorrowable)
                    {
                        AvailableResorces.Remove((IBorrowable)itemToDelete);
                    }
                    Console.WriteLine($"--------------\n{item.Title} removed from catalog");
                    exist = true;
                }
            }

            if (!exist)
            {
                Console.WriteLine("Sorry, resource was not found");
            }
            
        }

        public void DisplayLibraryInfo()
        {
            Console.WriteLine($"\n--------------\nCatalog\n--------------\n");

            foreach (var item in Catalog)
            {
                item.DisplayInfo();
            }

            Console.WriteLine($"\n--------------\nAvailable Resorces\n--------------\n");

            foreach (var item in AvailableResorces)
            {
                Console.WriteLine($"{item.ToString()}");
            }

            Console.WriteLine($"\n--------------\nBorrowed Resources\n--------------\n");

            foreach (var item in BorrowedResources)
            {
                Console.WriteLine($"{item.ToString()}");
            }
        }
    }
}
