using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Robin_Johansson
{
    internal class Vehicle
    {
        private string _brand;
        private string _model;
        private int _year;
        private string _color;
        private string _startUpNoise;
        
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public string StartUpNoise
        {
            get { return _startUpNoise; }
            set { _startUpNoise = value; }
        }

        public Vehicle(string brand, string model, int year, string color, string startUpNoise)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
            StartUpNoise = startUpNoise;
        }

        public void StartEngine()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(StartUpNoise);
            Console.ResetColor();
        }

        public void VehicleInfo()
        {
            Console.WriteLine($"Märke: {Brand} \nModel: {Model} \nÅrsmodell: {Year} \nMaxfart: {Color} \nStartljud: {StartUpNoise}");
        }

    }
}
