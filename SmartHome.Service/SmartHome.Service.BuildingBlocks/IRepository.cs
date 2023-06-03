namespace SmartHome.Service.BuildingBlocks;

public interface IRepository<T> where T : IAggregateRoot
{
    public IUnitOfWork UnitOfWork { get; }
}