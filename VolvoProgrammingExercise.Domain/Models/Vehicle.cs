namespace VolvoProgrammingExercise.Domain.Models
{
    public class Vehicle
    {
        public required ChassisId ChassisId { get; set; }

        public required VehicleType Type { get; set; }

        public ushort NumberOfPassangers 
        { 
            get
            {
                return Type switch
                {
                    VehicleType.Bus => 42,
                    VehicleType.Truck => 1,
                    VehicleType.Car => 4,
                    _ => throw new InvalidOperationException("Invalid vehicle type."),
                };
            } 
        }

        public required string Color { get; set; }
    }
}
