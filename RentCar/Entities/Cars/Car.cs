namespace RentCar.Entities.Cars;

public class Car
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public string? ImageUrl { get; set; }
    public required string Description { get; set; }
}