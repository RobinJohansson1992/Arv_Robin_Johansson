using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Robin_Johansson
{
    internal class Plane : Vehicle
    {
        //special property for plane:
        public int FlightHeight { get; set; } = 1000;
        public Plane (string brand, string model, int year, string color, string startUpNoise, int flightHeight) : base(brand, model, year, color, startUpNoise)
        {
            FlightHeight = flightHeight;
        }
        //method that displays all the info about the plane:
        public void PlaneInfo()
        {
            Console.WriteLine($"Märke: {Brand} \nModel: {Model} \nÅrsmodell: {Year} " +
                $"\nFärg: {Color} \nStartljud: {StartUpNoise} \nFlyghöjd: {FlightHeight} m");
        }
        //method that changes how high the plane can fly:
        public int ChangeHeight()
        {
            Console.WriteLine("Ange en ny flyghöjd för planet:");
            int userInput;
            while (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 0)
            {
                Console.WriteLine("Du måste ange en siffra över 0.");
            }
            return FlightHeight = userInput;
        }

    }
}
