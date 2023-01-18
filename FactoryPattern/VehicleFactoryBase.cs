namespace FactoryPattern
{
    public static class VehicleFactoryBase
    {
        public static IVehicle GetVehicl(string wheels)
        {
            switch (wheels.ToLower())
            {
                case "4":
                case "four":
                    return new Car();
                case "2":
                case "two":
                    return new Motorcycle();
                defaualt:
                    return new Car();
            };
        }
    }
}