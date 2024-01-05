using Microsoft.AspNetCore.Identity;
using RentCar.Entities.Base;
using RentCar.Entities.RentedCars;

namespace RentCar.Data;

public class ApplicationUser : IdentityUser, IEntity
{
     public List<RentedCar> RentedCars { get; set; } = new();
}