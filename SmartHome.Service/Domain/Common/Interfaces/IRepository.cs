namespace Domain.Common;

public interface IRepository<T> where T : IAggregateRoot
{
    // TODO: unit of work?
}