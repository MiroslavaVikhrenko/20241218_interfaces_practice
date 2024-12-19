using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241219_task9
{
    public class Basement : IPart
    {
        public Guid Id { get; set; }
        public Basement()
        {
            Id = Guid.NewGuid();
        }

        public void Inform()
        {
            Console.WriteLine($"Basement {Id} was built");
        }
    }
}
