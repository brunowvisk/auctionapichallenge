using AuctionAPIChallenge.Application.InterfacesApplication;
using AuctionAPIChallenge.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AuctionAPIChallenge.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculationController : ControllerBase
    {
        private readonly IVehicleCalculator _vehicleCalculator;

        public CalculationController(IVehicleCalculator vehicleCalculator)
        {
            _vehicleCalculator = vehicleCalculator;
        }

        [HttpPost("TotalCost")]
        public IActionResult CalculateTotalCost([FromBody] Vehicle vehicle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            CalculationResult calculationResult = _vehicleCalculator.CalculateTotalCost(vehicle);

            return Ok(calculationResult);
        }
    }

}