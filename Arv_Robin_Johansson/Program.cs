namespace Arv_Robin_Johansson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bil:");
            Console.ResetColor();

            //create car:
            var car1 = new Car("Lexus", "RX90", 2005, 200,
                "svart", "tjutjutju..VROOOOM", 4);
            //displays info about the car:
            car1.CarInfo();

            Console.Write($"En {car1.Color} {car1.Brand} {car1.Model} startar: ");
            //Start up noise:
            car1.StartEngine();
            //Special method for cars:
            car1.RemoveDoors();

            //method to change color of a vehicle:
            car1.ChangeVehicleColor();
            Console.WriteLine($"Bilen har nu färgen: {car1.Color}");

            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Flygplan:");
            Console.ResetColor();

            //create plane:
            var plane1 = new Plane("Mustang", "P-51", 1940, "röd", "fffFFFRRRRRRR...", 2000);
            //displays info about the plane:
            plane1.PlaneInfo();

            Console.Write($"En {plane1.Color} {plane1.Brand} {plane1.Model} startar: ");
            //start up noise:
            plane1.StartEngine();
            //special method for planes:
            plane1.ChangeHeight();
            Console.WriteLine($"Planets nya flyghöjd är {plane1.FlightHeight} m.");
            //randomly change the release year of the vehicle:
            plane1.ChangeYear();
            Console.WriteLine($"Fordonets tillverkningsår uppdaterades till: {plane1.Year}");

            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Moped:");
            Console.ResetColor();

            //create moped:
            var moped1 = new Moped("Crescent", "Compact", 1970, "blå", "fr-r-r...fr-r-RR *PANG*", 30);
            //displays info about the moped:
            moped1.MopedInfo();
            
            Console.Write($"En {moped1.Color} {moped1.Brand} {moped1.Model} startar: ");
            //start up noise:
            moped1.StartEngine();

            Console.WriteLine("Tryck enter för att trimma mopeden:");
            Console.ReadKey();
            //special method for moped:
            moped1.Trim();
            Console.WriteLine($"Mopeden kan nu köra i {moped1.MaxSpeed} km/h.");

            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sportbil:");
            Console.ResetColor();

            //create sportscar:
            var lambo = new SportsCar("Lamborghini", "Diablo", 2013,
                300, "Gul", "CHHHRAAAAHHH", 2, +50);
            //sportscar info:
            lambo.CarInfo();
            Console.WriteLine("Tryck enter för att sätta bilen i sportläge.");
            Console.ReadKey();
            //special method for sportscar:
            Console.WriteLine($"{lambo.Brand} {lambo.Model} har nu en maxhastighet på {lambo.ChangeToSportsMode()} km/h");

            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Jeep:");
            Console.ResetColor();

            var jeep1 = new Jeep("Jeep", "Wrangler", 2010, 180,
                "White", "BRUBRUBRUBR", 4, false);

            jeep1.CarInfo();

            jeep1.FourWheelDrive();

        }
    }
}
