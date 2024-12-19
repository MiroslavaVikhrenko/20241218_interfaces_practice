using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241219_task7
{
    /*
     Создайте массив объектов класса «Product». Реализуйте интерфейс «IComparable» для сравнения товаров по цене в методе CompareTo(). 
    Выведите на консоль список товаров, упорядоченный по цене.
    */
    internal class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CompareTo(Product? other)
        {
            return this.Price.CompareTo(other.Price);
        }
        public override string ToString()
        {
            return $"{Name} : {Price} CAD";
        }
    }
}
