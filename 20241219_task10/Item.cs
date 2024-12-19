using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241219_task10
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Item(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name} : {Id}";
        }
    }
}
