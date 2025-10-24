using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Robin_Johansson
{
    internal class Vehicle
    {
        //properties for all vehicles:
        public string Brand { get; set; } = "Volvo";
        public string Model { get; set; } = "V70";
        public int Year { get; set; } = 2000;
        public string Color { get; set; } = "silver";
        public string StartUpNoise { get; set; } = "BRUM";

        public Vehicle(string brand, string model, int year, string color, string startUpNoise)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
            StartUpNoise = startUpNoise;
        }

        //method that displays the start up noise of the vehicle
        public void StartEngine()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(StartUpNoise);
            Console.ResetColor();
        }
        //method that changes the color of the vehicle
        public string ChangeVehicleColor()
        {
            Console.WriteLine("Vilken färg vill du byta till?");
            Console.WriteLine("1. Vit");
            Console.WriteLine("2. Guld");
            Console.WriteLine("3. Silver");
            Console.WriteLine("4. Röd");
            Console.WriteLine("5. Grön");
            Console.WriteLine("6. Jag vill inte byta färg.");

            int userInput;
            //user can only choose whitin the numbers of the list:
            while (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 1 || userInput > 6)
            {
                Console.WriteLine("Du måste ange ett nummer från listan.");
            }

            switch (userInput)
            {
                case 1:
                    Color = "Vit";
                    break;
                case 2:
                    Color = "Guld";
                    break;
                case 3:
                    Color = "Silver";
                    break;
                case 4:
                    Color = "Röd";
                    break;
                case 5:
                    Color = "Grön";
                    break;
                case 6:
                    Color = Color;
                    break;
                default:
                    Color = Color;
                    break;
            }
            return Color;
        }

        //method that randomly sets a new release year of the vehicle:
        public int ChangeYear()
        {
            Console.WriteLine("Tryck enter för att ge fordonet ett nytt tillverkningsår:");
            Console.ReadKey();
            Random rnd = new Random();
            int newYear = rnd.Next(1900, 2025);
            return Year = newYear;
        }




    }
}
