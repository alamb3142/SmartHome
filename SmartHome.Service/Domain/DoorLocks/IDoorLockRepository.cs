using Domain.Common;

namespace Domain.Doorlocks;

public interface IDoorLockRepository : IRepository<DoorLock>
{
    public Task<IEnumerable<DoorLock>> GetAllAsync(CancellationToken cancellationToken);
    public Task<DoorLock> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    public Task<IEnumerable<DoorLock>> GetByIdAsync(IEnumerable<Guid> ids, CancellationToken cancellationToken);
    public Task<IEnumerable<DoorLock>> GetByDeviceId(Guid deviceId, CancellationToken cancellationToken);
    public void Update(DoorLock doorLock, CancellationToken cancellationToken);
    public void Add(DoorLock doorLock, CancellationToken cancellationToken);
    public void Delete(DoorLock doorLock, CancellationToken cancellationToken);
}