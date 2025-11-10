using VolvoProgrammingExercise.Domain.Models;

namespace VolvoProgrammingExercise.Domain.Interfaces
{
    public interface IVehicleRepository
    {
        Task<IEnumerable<Vehicle>> GetAll();
    }
}
