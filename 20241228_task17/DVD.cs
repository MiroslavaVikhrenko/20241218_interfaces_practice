using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241228_task17
{
    /*
     Классы Book, Magazine, DVD: Реализуют интерфейс IMediaItem. Классы Book и DVD также реализуют интерфейс IBorrowable.
     */
    public class DVD : IMediaItem, IBorrowable
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public DateTime Year { get; set; }
        public DVD(string title, string author, DateTime year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public override string ToString()
        {
            return $"DVD: {Title} by {Author}, {Year.Year}";
        }
        public void DisplayInfo()
        {
            Console.WriteLine(ToString());
        }

        public void Borrow(Library library)
        {
            bool success = false;

            foreach (var item in library.AvailableResorces.ToList())
            {
                if (item == this)
                {
                    library.BorrowedResources.Add(this);
                    library.AvailableResorces.Remove(this);
                    Console.WriteLine($"DVD {Title} was successfully borrowed");
                    success = true;
                }
            }

            if (!success)
            {
                Console.WriteLine($"Sorry, DVD {Title} is not available");
            }
        }

        public void Return(Library library)
        {
            library.BorrowedResources.Remove(this);
            library.AvailableResorces.Add(this);
            Console.WriteLine($"DVD {Title} was returned");
        }
    }
}
