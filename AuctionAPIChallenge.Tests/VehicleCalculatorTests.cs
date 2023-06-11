using AuctionAPIChallenge.Application.Services;
using AuctionAPIChallenge.Domain.Entities;
using AuctionAPIChallenge.Domain.Enums;
using Microsoft.Extensions.Logging.Abstractions;

namespace AuctionAPIChallenge.Tests
{
    public class VehicleCalculatorTests
    {
        private readonly VehicleCalculator _vehicleCalculator;

        public VehicleCalculatorTests()
        {
            _vehicleCalculator = new VehicleCalculator(new NullLogger<VehicleCalculator>());
        }

        [Fact]
        public void UnitTest1()
        {
            // Arrange
            var vehicle = new Vehicle
            {
                BasePrice = 398.00m,
                Type = VehicleType.Common
            };

            // Act
            var result = _vehicleCalculator.CalculateTotalCost(vehicle);

            // Assert
            Assert.Equal(550.76m, result.TotalCost);
        }

        [Fact]
        public void UnitTest2()
        {
            // Arrange
            var vehicle = new Vehicle
            {
                BasePrice = 501m,
                Type = VehicleType.Common
            };

            // Act
            var result = _vehicleCalculator.CalculateTotalCost(vehicle);

            // Assert
            Assert.Equal(671.02m, result.TotalCost);
        }

        [Fact]
        public void UnitTest3()
        {
            // Arrange
            var vehicle = new Vehicle
            {
                BasePrice = 57m,
                Type = VehicleType.Common
            };

            // Act
            var result = _vehicleCalculator.CalculateTotalCost(vehicle);

            // Assert
            Assert.Equal(173.14m, result.TotalCost);
        }

        [Fact]
        public void UnitTest4()
        {
            // Arrange
            var vehicle = new Vehicle
            {
                BasePrice = 1800,
                Type = VehicleType.Luxury
            };

            // Act
            var result = _vehicleCalculator.CalculateTotalCost(vehicle);

            // Assert
            Assert.Equal(2167.00m, result.TotalCost);
        }

        [Fact]
        public void UnitTest5()
        {
            // Arrange
            var vehicle = new Vehicle
            {
                BasePrice = 1100,
                Type = VehicleType.Common
            };

            // Act
            var result = _vehicleCalculator.CalculateTotalCost(vehicle);

            // Assert
            Assert.Equal(1287.00m, result.TotalCost);
        }

        [Fact]
        public void UnitTest6()
        {
            // Arrange
            var vehicle = new Vehicle
            {
                BasePrice = 1000000m,
                Type = VehicleType.Luxury
            };

            // Act
            var result = _vehicleCalculator.CalculateTotalCost(vehicle);

            // Assert
            Assert.Equal(1040320.00m, result.TotalCost);
        }
    }
}