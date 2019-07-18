using System;
using System.Collections.Generic;

namespace GrowPlant.Models
{
    class Plant
    {
        public string Name { get; set; }
        public int WaterLevel { get; set; }
        public int Height { get; set; }
        public int Foliage { get; set; }
        public int Happiness { get; set; }
        public bool IsAlive { get; set; }

        public Plant()
        {
            Name = "";
            WaterLevel = 3;
            Height = 0;
            Foliage = 0;
            Happiness = 5;
            IsAlive = true;
        }

        public void Water()
        {
            WaterLevel += 2;
            Height += 1;
        }

        public void Fertilize()
        {
            Height += 3;
            Happiness -= 1;
        }

        public void Sunshine()
        {
            Foliage += 2;
            Height += 1;
            WaterLevel -= 2;
        }

        public void Sing()
        {
            Happiness += 1;
        }

        public void Fungus()
        {
            Console.WriteLine($">>> {Name} suffered from a fungal infection, and its happiness was lowered.");
            Happiness -= 2;
        }

        public void Rainstorm()
        {
            Console.WriteLine(">>> A rainstorm swept through the area and flooded the soil.");
            WaterLevel += 4;
        }

        public void Deer()
        {
            Console.WriteLine(">>> Oh no! Looks like a deer ate your plant!");
            IsAlive = false;
        }

        public void NiceDay()
        {
            Console.WriteLine($">>> Wow! A nice day boosted {Name}'s foliage, height, and happiness!");
            Foliage += 2;
            Height += 3;
            Happiness += 3;
        }

        public void RandomEvent()
        {
            List<Action> events = new List<Action> () { Fungus, Rainstorm, Deer, NiceDay };

            Random rand = new Random();
            int eventNumber = rand.Next(0, 4);

            events[eventNumber]();
        }

        public void DetermineAlive()
        {
            if (WaterLevel < 0 || WaterLevel > 7 || Happiness < 0)
            {
                IsAlive = false;
            }
        }

        public void ResetPlant()
        {
            WaterLevel = 3;
            Height = 0;
            Foliage = 0;
            Happiness = 5;
            IsAlive = true;
        }
    }
}
