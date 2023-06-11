using AuctionAPIChallenge.Application.InterfacesApplication;
using AuctionAPIChallenge.Domain.Entities;
using AuctionAPIChallenge.Domain.Enums;
using Microsoft.Extensions.Logging;

namespace AuctionAPIChallenge.Application.Services
{
    public class VehicleCalculator : IVehicleCalculator
    {
        private readonly ILogger<VehicleCalculator> _logger;

        public VehicleCalculator(ILogger<VehicleCalculator> logger)
        {
            _logger = logger;
        }

        public CalculationResult CalculateTotalCost(Vehicle vehicle)
        {
            CalculationResult result = new CalculationResult();

            try
            {
                // Basic fee
                if (vehicle.Type == VehicleType.Common)
                {
                    result.BasicFee = Math.Clamp(vehicle.BasePrice * 0.1m, 10m, 50m);
                }
                else if (vehicle.Type == VehicleType.Luxury)
                {
                    result.BasicFee = Math.Clamp(vehicle.BasePrice * 0.1m, 25m, 200m);
                }

                // Special fee
                if (vehicle.Type == VehicleType.Common)
                {
                    result.SpecialFee = vehicle.BasePrice * 0.02m;
                }
                else if (vehicle.Type == VehicleType.Luxury)
                {
                    result.SpecialFee = vehicle.BasePrice * 0.04m;
                }

                // Association fee
                if (vehicle.BasePrice <= 500m)
                {
                    result.AssociationFee = 5m;
                }
                else if (vehicle.BasePrice <= 1000m)
                {
                    result.AssociationFee = 10m;
                }
                else if (vehicle.BasePrice <= 3000m)
                {
                    result.AssociationFee = 15m;
                }
                else
                {
                    result.AssociationFee = 20m;
                }

                // Storage Fee
                result.StorageFee = 100m;

                // Total cost
                result.TotalCost = vehicle.BasePrice + result.BasicFee + result.SpecialFee + result.AssociationFee + result.StorageFee;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred!");
            }

            return result;
        }
    }
}