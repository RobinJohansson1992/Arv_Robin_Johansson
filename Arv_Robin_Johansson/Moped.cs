using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Robin_Johansson
{
    internal class Moped : Vehicle
    {
        //special property for moped:
        public int MaxSpeed { get; set; } = 30;
        public Moped (string name, string model, int year, string color, string startUpNoise, int maxSpeed) : base(name, model, year, color, startUpNoise)
        {
            MaxSpeed = maxSpeed;
        }
        //method that displays all the info about the moped:
        public void MopedInfo()
        {
            Console.WriteLine($"Märke: {Brand} \nModel: {Model} \nÅrsmodell: {Year} " +
                $"\nFärg: {Color} \nStartljud: {StartUpNoise} \nMaxfart: {MaxSpeed}");
        }
        //method that makes the moped go faster:
        public int Trim()
        {
            return MaxSpeed += 20;
        }
    }
}
