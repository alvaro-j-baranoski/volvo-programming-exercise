using VolvoProgrammingExercise.Application.DTOs;

namespace VolvoProgrammingExercise.Application.Services
{
    public interface IVehicleService
    {
        Task<IEnumerable<VehicleDTO>> GetAllVehicles();
    }
}
