using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Robin_Johansson
{
    internal class Car : Vehicle
    {
        //special property for Car:
        public int NumberOfDoors { get; set; } = 4;
        public Car(string brand, string model, int year, string color, string startUpNoise, int numberOfDoors) : base(brand, model, year, color, startUpNoise)
        {
            NumberOfDoors = numberOfDoors;
        }
        //Method that displays all the info about the car:
        public void CarInfo()
        {
            Console.WriteLine($"Märke: {Brand} \nModel: {Model} \nÅrsmodell: {Year} " +
                $"\nFärg: {Color} \nStartljud: {StartUpNoise} \nAntal dörrar: {NumberOfDoors}");
        }
        //Method for removing doors on the car:
        public void RemoveDoors()
        {
            Console.WriteLine("Skriv in hur många dörrar du vill ta bort på bilen.");

            int userInput;
            while(!int.TryParse(Console.ReadLine(), out userInput) || userInput < 0 || userInput > NumberOfDoors)
            {
                Console.WriteLine($"Du måste ange ett nummer mellan 0 och {NumberOfDoors}");
            }
            Console.WriteLine($"Du tog bort {userInput} dörr(ar) på bilen. Bilen har nu {NumberOfDoors - userInput} dörr(ar).");
             
        }
    }
}
