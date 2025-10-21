using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Robin_Johansson
{
    internal class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public Car(string model, string brand, int year, int maxSpeed, string startUpNoise, int numberOfDoors) : base(brand, model, year, maxSpeed, startUpNoise)
        {
            Model = model;
            Brand = brand;
            Year = year;
            MaxSpeed = maxSpeed;
            StartUpNoise = startUpNoise;
            NumberOfDoors = numberOfDoors;
        }
    }
}
