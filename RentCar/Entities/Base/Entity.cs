namespace RentCar.Entities.Base;

public class Entity : IEntity
{
    public string Id { get; set; }

    public Entity()
    {
        Id = Guid.NewGuid().ToString();
    }
}