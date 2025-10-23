namespace Arv_Robin_Johansson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car("Lexus", "RX90", 2005, "svart", "tjutjutju..VROOOOM", 4);

            car1.VehicleInfo();

            Console.Write($"En {car1.Color} {car1.Model} {car1.Brand} startar: ");
            
            car1.StartEngine();

            car1.RemoveDoors();
            
        }
    }
}
