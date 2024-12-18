using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241218_interfaces_practice
{
    /*
        Создать интерфейс «Транспортное средство». 
        Транспортные средства с различными реализациями расчета затраченного топлива: 
        машина, машина-гибрид, вертолет.
     */
    public abstract class Transport 
    {
        public abstract string Name { get; set; }
        public abstract int MaxSpeed { get; set; }
        public abstract int FuelConsumption { get; set; }

    }
}
