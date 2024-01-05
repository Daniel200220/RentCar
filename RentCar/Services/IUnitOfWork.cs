namespace RentCar.Services;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync();
}