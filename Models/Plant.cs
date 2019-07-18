using System;

namespace GrowPlant.Models
{
    class Plant
    {
        public string Name { get; set; }
        public int WaterLevel { get; set; }
        public int Height { get; set; }
        public int Foliage { get; set; }
        public int Happiness { get; set; }

        public Plant()
        {
            Name = "";
            WaterLevel = 3;
            Height = 0;
            Foliage = 0;
            Happiness = 5;
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

        public bool IsAlive()
        {
            if( 0 < WaterLevel && WaterLevel < 7)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void ResetPlant()
        {
            WaterLevel = 3;
            Height = 0;
            Foliage = 0;
            Happiness = 5;
        }
    }
}
