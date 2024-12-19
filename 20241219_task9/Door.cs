using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241219_task9
{
    public class Door : IPart
    {
        public Guid Id { get; set; }
        public Door()
        {
            Id = Guid.NewGuid();
        }

        public void Inform()
        {
            Console.WriteLine($"Door {Id} was built");
        }
    }
}
