namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Many Wheels would you like?");
            var numberOfWheels = Console.ReadLine();

           
            IVehicle vehicle = VehicleFactory.GetVehicle(numberOfWheels);


            
            vehicle.Drive();
           
        }
    }
}
