using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241219_task9
{
    public class Roof : IPart
    {
        public Guid Id { get; set; }
        public Roof()
        {
            Id = Guid.NewGuid();
        }

        public void Inform()
        {
            Console.WriteLine($"Roof {Id} was built");
        }
    }
}
