namespace _20241219_task10
{
    internal class Program
    {
        /*Создайте интерфейс IWarehouse, который представляет склад товаров. 
         * Интерфейс IWarehouse должен содержать: 
         * >> Метод для добавления товара на склад. 
         * >> Метод для удаления товара по ID. 
         * >> Метод для получения общего количества товаров на складе. 
         * >> Индексатор, позволяющий получать доступ к товарам по их ID.
         * Реализуйте класс Warehouse, который поддерживает хранение товаров с возможностью их добавления, 
         * удаления и получения информации по индексу. 
         * Каждый Warehouse должен иметь: 
         * >> Уникальный идентификатор (ID). 
         * >> Название. 
         * >> Количество на складе.     
         */
        static void Main(string[] args)
        {
            Warehouse w = new Warehouse("Glenmore Warehouse");

            w.Info();

            Item item = new Item("Cabinet");

            w.AddItem(item);

            w.Info();

            w.Count();

            try
            {
                Console.WriteLine("\nEnter an index of item for search\n");
                int index = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nThe following item found:\n");
                Console.WriteLine(w[index]);

                Console.WriteLine("\nEnter an ID of the item you want to remove:\n");

                Guid id = Guid.Parse(Console.ReadLine());

                w.RemoveItem(id);

                w.Info();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
