using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241226_task11
{
    /*
     Описать интерфейс, включающий следующие методы:

    void PrintReversed(List) - распечатать список в обратном порядке
    void AddLast(List, int value) - добавить новый элемент со значением value в конец
    void DeleteLast(List) - удалить последний элемент
    List Copy(List) - создать копию заданного списка
    void InsertBefore(List, Node, int) - вставка нового элемента перед заданным

    Создать класс, реализующий этот интерфейс для объектов типа string (выполнять с использованием класса List). 
    Написать программу, демонстрирующую работу с экземплярами класса.
     */
    public class Class1 : Interface1<string>
    {
        public void AddLast(List<string> list, string value)
        {
            list.Add(value);
        }

        public List<string> Copy(List<string> list)
        {
            return list;
        }

        public void DeleteLast(List<string> list)
        {
            list.RemoveAt(list.Count - 1);
        }

        public void InsertBefore(List<string> list, int node, string value)
        {
            list.Insert(node, value);
        }

        public void PrintReverse(List<string> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.WriteLine($"{i+1}. {list[i]}");
            }
        }
    }
}
