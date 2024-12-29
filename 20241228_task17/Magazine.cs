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
    public class Magazine : IMediaItem
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public DateTime Year { get; set; }
        public Magazine(string title, string author, DateTime year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"MAGAZINE: {Title} by {Author}, {Year.Year}");
        }
    }
}
