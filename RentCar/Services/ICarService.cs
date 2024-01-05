using RentCar.Data;
using RentCar.Entities.Cars;

namespace RentCar.Services;

public interface ICarService
{
    
    Task<IEnumerable<Car>> GetCarsAsync();
    Task<Car?> GetCarByIdAsync(string id);
    
}