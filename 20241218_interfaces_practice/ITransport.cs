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
    internal interface ITransport
    {
        void CalculateFuelByTime(int hours, int speed);
        void CalculateFuelByDistance(int km);
    }
}
