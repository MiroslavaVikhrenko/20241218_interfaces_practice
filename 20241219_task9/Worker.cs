using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241219_task9
{
    public class Worker : IWorker
    {
        public string Name { get; set; }
        public Worker(string name)
        {
            Name = name;
        }

        public void Work()
        {
            Console.WriteLine($"{Name} worker is building\n");
        }
    }
}
