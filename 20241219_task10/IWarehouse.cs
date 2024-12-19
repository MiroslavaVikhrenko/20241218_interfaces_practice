using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241219_task10
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
    public interface IWarehouse
    {
        void AddItem(Item item);
        void RemoveItem(Guid id);
        int Count();
        Item this[int index]
        {
            get;
            set;
        }
    }
}
