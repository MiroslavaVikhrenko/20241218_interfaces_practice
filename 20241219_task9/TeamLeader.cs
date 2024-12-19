using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241219_task9
{
    public class TeamLeader : IWorker
    {
        public string Name {  get; set; }
        public TeamLeader(string name)
        {
            Name = name;
        }

        public void Work()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Team Lead {Name} reported that the house was built!");
            Console.ResetColor();
        }
    }
}
