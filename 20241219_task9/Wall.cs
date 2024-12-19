using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241219_task9
{
    public class Wall : IPart
    {
        public Guid Id { get; set; }
        public Wall()
        {
            Id = Guid.NewGuid();
        }

        public void Inform()
        {
            Console.WriteLine($"Wall {Id} was built");
        }
    }
}
