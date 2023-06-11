using AuctionAPIChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionAPIChallenge.Application.InterfacesApplication
{
    public interface IVehicleCalculator
    {
        CalculationResult CalculateTotalCost(Vehicle vehicle);
    }
}
