﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241218_task3
{
    /*
         Напишите программу, в которой будет описан интерфейс с методом без аргументов, 
        который возвращает результатом целое число. На основе интерфейса создайте два класса. 
        У каждого класса должно быть целочисленное поле. 
        В первом классе метод результатом возвращает сумму четных чисел, 
        во втором классе метод возвращает результатом сумму нечетных чисел. 
        Количество слагаемых в сумме определяется полем объекта, из которого вызывается метод. 
        Проверьте работу метода, получив доступ к объекту класса через объектную переменную и через интерфейсную переменную.
     */
    internal interface ICalculate
    {
        int Calculate();
    }
}
