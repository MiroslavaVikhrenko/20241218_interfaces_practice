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
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();

            List<string> c2 = new List<string>();

            c1.AddLast(c2, "cat");
            c1.AddLast(c2, "dog");
            c1.AddLast(c2, "lizard");
            c1.AddLast(c2, "bird");

            c1.PrintReverse(c2);

            c1.DeleteLast(c2);

            c1.InsertBefore(c2, 1, "cow");

            List<string> c3 = c1.Copy(c2);

            c1.PrintReverse(c3);

            Console.ReadKey();
        }
    }
}
