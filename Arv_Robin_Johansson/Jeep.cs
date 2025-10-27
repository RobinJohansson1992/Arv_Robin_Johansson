using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Robin_Johansson
{
    internal class Jeep : Car
    {
        public bool PanelSwitch { get; set; } = false;
        public Jeep(string brand, string model, int year, int speed, string color, string startUpNoise, int numberOfDoors, bool panelSwitch) 
            : base(brand, model, year, speed, color, startUpNoise, numberOfDoors)
        {
            PanelSwitch = panelSwitch;
        }

        public void FourWheelDrive()
        {
            Console.WriteLine("Ajdå, du körde in på en lerig väg! Skriv 4 och tryck enter för att sätta på fyrhjulsdrift!");


            while (!PanelSwitch)
            {
                string userInput = Console.ReadLine();


                if (userInput == "4")
                {
                    Console.WriteLine("Snyggt! Du satte på fyrhjulsdrift och tog dig loss ur leran.");
                    PanelSwitch = true;
                }
                else
                {
                    Console.WriteLine("Nej! Du håller på att köra fast, du måste skriva in 4 och trycka enter!");
                    PanelSwitch = false;
                }
            }

        }
    }
}
