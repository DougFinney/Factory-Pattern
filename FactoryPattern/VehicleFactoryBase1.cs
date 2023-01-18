namespace FactoryPattern
{
    public static class VehicleFactoryBase1
    {
        public static IVehicle GetVehicle(string wheels)
        {
            switch (wheels.ToLower())
            {
                case "4":
                case "four":
                    return new Car();
                case "2":
                case "two":
                    return new Motorcycle();
                default:
                    return new Car();
            }
        }
    }
}