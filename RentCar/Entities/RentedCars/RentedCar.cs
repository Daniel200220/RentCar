using RentCar.Data;
using RentCar.Entities.Base;
using RentCar.Entities.Cars;

namespace RentCar.Entities.RentedCars;

public class RentedCar : Entity
{
    public required string CarId { get; set; }
    public required Car Car { get; set; }
    public required ApplicationUser User { get; set; }
    public required DateOnly RentedAt { get; set; }
    public required DateOnly ReturnedAt { get; set; }
}