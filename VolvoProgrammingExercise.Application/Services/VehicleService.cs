using VolvoProgrammingExercise.Application.DTOs;
using VolvoProgrammingExercise.Domain.Interfaces;
using VolvoProgrammingExercise.Domain.Models;

namespace VolvoProgrammingExercise.Application.Services
{
    public class VehicleService(IVehicleRepository vehicleRepository) : IVehicleService
    {
        private readonly IVehicleRepository vehicleRepository = vehicleRepository;

        public async Task<IEnumerable<VehicleDTO>> GetAllVehicles()
        {
            IEnumerable<Vehicle> vehiclesFromDb = await vehicleRepository.GetAll();

            // 2. Map the domain entities to the DTOs
            var vehicleDtos = vehiclesFromDb.Select(v => new VehicleDTO
            {
                ChassisSeries = v.ChassisId.Series,
                ChassisNumber = v.ChassisId.Number,
                Type = v.Type.ToString(),
                NumberOfPassengers = v.NumberOfPassangers,
                Color = v.Color
            }).ToList();

            return vehicleDtos;
        }
    }
}
