using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241219_task9
{
    public class Window : IPart
    {
        public Guid Id { get; set; }
        public Window()
        {
            Id = Guid.NewGuid();
        }

        public void Inform()
        {
            Console.WriteLine($"Window {Id} was built");
        }
    }
}
