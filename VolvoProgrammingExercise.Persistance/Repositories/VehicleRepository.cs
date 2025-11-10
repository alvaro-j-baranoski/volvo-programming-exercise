using VolvoProgrammingExercise.Domain.Interfaces;
using VolvoProgrammingExercise.Domain.Models;

namespace VolvoProgrammingExercise.Persistance.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        public Task<IEnumerable<Vehicle>> GetAll()
        {
            List<Vehicle> result =
            [
                new Vehicle
                {
                    ChassisId = new()
                    {
                        Number = 1,
                        Series = "Series S"
                    },
                    Type = VehicleType.Truck,
                    Color = "White"
                }
            ];

            return Task.FromResult(result.AsEnumerable());
        }
    }
}
