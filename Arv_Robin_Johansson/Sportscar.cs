using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Robin_Johansson
{
    internal class SportsCar : Car
    {
        public int SportsMode { get; set; } = 50;
        public SportsCar(string brand, string model, int year, int speed, string color, string startUpNoise, int numberOfDoors, int sportsMode) 
            : base(brand, model, year, speed, color, startUpNoise, numberOfDoors)
        {
            SportsMode = sportsMode;
        }

        public int ChangeToSportsMode()
        {
            return SportsMode + Speed;
        }
    }
}
