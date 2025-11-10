using Microsoft.AspNetCore.Mvc;
using VolvoProgrammingExercise.Application.DTOs;
using VolvoProgrammingExercise.Application.Services;
using VolvoProgrammingExercise.Domain.Models;

namespace VolvoProgrammingExercise.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleController(IVehicleService vehicleService) : ControllerBase
    {
        private readonly IVehicleService vehicleService = vehicleService;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<VehicleDTO>>> ListAllVehicles()
        {
            var result = await vehicleService.GetAllVehicles();
            return Ok(result);
        }
    }
}
