namespace VolvoProgrammingExercise.Application.DTOs
{
    public class VehicleDTO
    {
        public required string ChassisSeries { get; set; }
        public uint ChassisNumber { get; set; }
        public required string Type { get; set; }
        public int NumberOfPassengers { get; set; }
        public required string Color { get; set; }
    }
}
