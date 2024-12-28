using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
namespace _20241226_task11
{
    public interface Interface1<T>
    {
        void PrintReverse(List<T> list);
        void AddLast(List<T> list, T value);
        void DeleteLast(List<T> list);
        List<T> Copy(List<T> list);
        void InsertBefore(List<T> list, int node, T value);

    }
}
