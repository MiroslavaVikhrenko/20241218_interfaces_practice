using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241219_task9
{
    public class House
    {
        public Guid Id { get; set; }
        public Basement Basement { get; set; }
        public Wall[] Walls { get; set; } = new Wall[4];
        public Door Door { get; set; }
        public Window[] Windows { get; set; } = new Window[4];
        public Roof Roof { get; set; }

        public House(List<IPart> parts)
        {
            Id = Guid.NewGuid();
            int wallCount = 0;
            int windowCount = 0;
            foreach (IPart part in parts)
            {               
                if (part is Basement)
                {
                    Basement = (Basement)part;
                }
                if (part is Wall)
                {
                    Walls[wallCount] = (Wall)part;
                    wallCount++;
                }
                if (part is Door)
                {
                    Door = (Door)part;
                }
                if (part is Window)
                {
                    Windows[windowCount] = (Window)part;
                    windowCount++;
                }
                if (part is Roof)
                {
                    Roof = (Roof)part;
                }
            }
        }

        public void Info()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            int length = 18;

            for (int i = 0; i <= length; i++)
            {
                if (i % 2 == 0)
                {
                    int spaceLength = (length / 2) - (i / 2);
                    for (int spacies = 0;  spacies <= spaceLength; spacies++)
                    {
                        Console.Write(" ");
                    }
                    for (int stars = 0; stars <= i; stars++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            for ( int i = 0; i <= length - 6; i++)
            {
                Console.WriteLine("*********************");
            }


            Console.ResetColor();

            Console.WriteLine($"\n\nHouse {Id} details:\nBasement - {Basement.Id}\nDoor - {Door.Id}\n Roof - {Roof.Id}");
            for (int i = 0; i < Walls.Length; i++)
            {
                Console.WriteLine($"Wall #{i + 1} - {Walls[i].Id}");
            }
            for (int i = 0; i < Windows.Length; i++)
            {
                Console.WriteLine($"Window #{i + 1} - {Windows[i].Id}");
            }
        }
    }
}
