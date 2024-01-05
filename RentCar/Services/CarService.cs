using Microsoft.EntityFrameworkCore;
using RentCar.Data;
using RentCar.Entities.Cars;

namespace RentCar.Services;

public class CarService : ICarService
{
    private readonly ApplicationDbContext _context;
    
    public CarService(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Car>> GetCarsAsync()
    {
        return await _context.Cars.ToListAsync();
    }

    public async Task<Car?> GetCarByIdAsync(string id)
    {
        return await _context.Cars.FirstOrDefaultAsync(c => c.Id == id);
    }
}