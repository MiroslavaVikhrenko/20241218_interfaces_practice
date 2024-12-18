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
    public class Helicopter : Transport, ITransport
    {
        public override string Name { get; set; }
        public override int MaxSpeed { get; set; }
        public override int FuelConsumption { get; set; }

        public Helicopter(string name, int maxSpeed, int fuelConsumption)
        {
            Name = name;
            MaxSpeed = maxSpeed;
            FuelConsumption = fuelConsumption;
        }

        public override string ToString()
        {
            return $"Helicopter {Name}, max speed is {MaxSpeed} km/h. fuel consumption is {FuelConsumption} l/km";
        }

        public void CalculateFuelByDistance(int km)
        {
            Console.WriteLine($"For helicopter {Name} you need {FuelConsumption * km} l for distance {km} km");

        }

        public void CalculateFuelByTime(int hours, int speed)
        {
            if (speed <= MaxSpeed)
            {
                Console.WriteLine($"For helicopter {Name} you need {FuelConsumption * (hours * speed)} l for distance {hours * speed} km - this the distance you cover if you move for {hours} h with speed {speed} km/h");
            }
            else
            {
                Console.WriteLine($"Helicopter {Name} cannot run with speed {speed} because it exceeds max speed {MaxSpeed} km/h");
            }
        }
    }
}
