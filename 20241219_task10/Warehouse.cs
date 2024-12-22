using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _20241219_task10
{
    public class Warehouse : IWarehouse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Item> Items { get; set; }

        public Item this[int index]
        {
            get
            {
                return Items[index];
            }
            set
            {
                Items[index] = value;
            }

        }

        public Warehouse(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            Items = new List<Item>()
            {
                new Item("Table"),
                new Item("Bed"),
                new Item("Chair"),
                new Item("Armchair"),
                new Item("Shelf"),
                new Item("Desk")
            };
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
            Console.WriteLine($"\nNew item added to {Name}:\n {item}\n");
        }

        public void RemoveItem(Guid id)
        {
            Item? itemFound = null;
            foreach (Item item in Items)
            {
                if (item.Id == id)
                {
                    itemFound = item;
                }
            }
            Items.Remove(itemFound);
            Console.WriteLine($"\nItem was deleted from {Name}:\n {itemFound}\n");
        }

        public int Count()
        {
            Console.WriteLine($"\n{Name} has total items:\n {Items.Count}\n");
            return (int) Items.Count;
        }

        public void Info()
        {
            Console.WriteLine($"\nWarehouse info: {Name} {Id}\n");
            int count = 1;
            foreach (Item item in Items) 
            {
                Console.WriteLine($"{count}. {item}");
                count++;
            }
            Console.WriteLine();
        }
    }
}
