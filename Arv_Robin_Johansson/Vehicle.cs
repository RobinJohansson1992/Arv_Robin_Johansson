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
        private int _maxSpeed;
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
        public int MaxSpeed
        {
            get { return _maxSpeed; }
            set { _maxSpeed = value; }
        }
        public string StartUpNoise
        {
            get { return _startUpNoise; }
            set { _startUpNoise = value; }
        }

        public Vehicle(string brand, string model, int year, int maxSpeed, string startUpNoise)
        {
            Brand = brand;
            Model = model;
            Year = year;
            MaxSpeed = maxSpeed;
            StartUpNoise = startUpNoise;
        }

        public void StartEngine()
        {
            Console.WriteLine(StartUpNoise);
        }


    }
}
