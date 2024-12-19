using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241219_task9
{
    public class Project
    {
        public Team Team { get; set; }
        public List<IPart> builtParts { get; set; }
        public List<House> houses { get; set; }
        public Random Rnd { get; set; }

        public Project()
        {
            Team = new Team();
            builtParts = new List<IPart>();
            houses = new List<House>();
            Rnd = new Random();
        }

        public void CheckProgress()
        {
            if (CheckBasement() && CheckWalls() && CheckWindows() && CheckRoof() && CheckDoor())
            {
                House house = new House(builtParts);
                house.Info();
                houses.Add(house);
                Team.TeamLeader.Work();                
                builtParts.Clear();
            }
            else if (!CheckBasement())
            {
                int n = Rnd.Next(0, 11);
                Team.Workers[n].Work();
                Basement basement = new Basement();
                builtParts.Add(basement);
                basement.Inform();
            }
            else if (!CheckWalls())
            {
                int n = Rnd.Next(0, 11);
                Team.Workers[n].Work();
                Wall wall = new Wall();
                builtParts.Add(wall);
                wall.Inform();
            }
            else if (!CheckDoor())
            {
                int n = Rnd.Next(0, 11);
                Team.Workers[n].Work();
                Door door = new Door();
                builtParts.Add(door);
                door.Inform();
            }
            else if (!CheckWindows())
            {
                int n = Rnd.Next(0, 11);
                Team.Workers[n].Work();
                Window window = new Window();
                builtParts.Add(window);
                window.Inform();
            }
            else if (!CheckRoof())
            {
                int n = Rnd.Next(0, 11);
                Team.Workers[n].Work();
                Roof roof = new Roof();
                builtParts.Add(roof);
                roof.Inform();
            }
        }

        private bool CheckBasement()
        {
            foreach (var part in builtParts) 
            {
                if (part is Basement)
                {
                    return true;
                }
            }
            return false;
        }
        private bool CheckWalls()
        {
            int count = 0;
            foreach (var part in builtParts)
            {
                if (part is Wall)
                {
                    count++;
                }
            }
            if (count == 4) return true;
            return false;
        }
        private bool CheckDoor()
        {
            foreach (var part in builtParts)
            {
                if (part is Door)
                {
                    return true;
                }
            }
            return false;
        }
        private bool CheckWindows()
        {
            int count = 0;
            foreach (var part in builtParts)
            {
                if (part is Window)
                {
                    count++;
                }
            }
            if (count == 4) return true;
            return false;
        }
        private bool CheckRoof()
        {
            foreach (var part in builtParts)
            {
                if (part is Roof)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
