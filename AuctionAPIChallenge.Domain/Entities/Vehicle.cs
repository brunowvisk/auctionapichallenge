using AuctionAPIChallenge.Domain.Enums;

namespace AuctionAPIChallenge.Domain.Entities
{
    public class Vehicle
    {
        public decimal BasePrice { get; set; }

        public VehicleType Type { get; set; }

    }
}