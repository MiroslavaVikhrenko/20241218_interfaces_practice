﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241219_task5
{
    /*
         Описать интерфейсы:

«IResultShowInterface»: содержащий метод – Show. 
«ISumInterface»: содержащий метод – Sum. 

Используя интерфейсы, создать класс «Counter»  для расчета расчета электроэнергии по вводным показания и ее стоимости. Примерный вывод в консоль:

Расчет электроэнергии

Начальные показания : 568
Конечные показания : 723
Цена за 1кВт/ч : 1,68
Сумма за электроэнергию : 260,40
         */
    internal class Counter : ISum<double>, IResultShow
    {
        public double StartPoint { get; set; }
        public double EndPoint { get; set; }
        const double Price = 1.68;

        public Counter(double start, double end)
        {
            StartPoint = start;
            EndPoint = end;
        }

        public double Sum()
        {
            return (EndPoint - StartPoint) * Price;
        }

        public void Show()
        {
            Console.WriteLine($"Electricity Overview\n\nStart point : {StartPoint}\nEnd Point: {EndPoint}\nPrice for kW/h : {Price}\nSum for electricity : {Math.Round(Sum(), 2)}");
        }
    }
}
