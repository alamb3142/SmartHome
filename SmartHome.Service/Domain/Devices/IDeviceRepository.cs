using Domain.Common;
using Domain.Devices;

namespace Domain;

public interface IDeviceRepository : IRepository<Device>
{
    public Task<List<Device>> GetAllAsync(CancellationToken cancellationToken);
    public Task<Device> GetById(int id, CancellationToken cancellationToken);
    public Task<List<Device>> GetById(IEnumerable<int> ids, CancellationToken cancellationToken);
    public Task<List<Device>> GetByControlId(int controlId, CancellationToken cancellationToken);
    public Task<List<Device>> GetByControlId(IEnumerable<int> controlIds, CancellationToken cancellationToken);
    public Task AddAsync(Device device, CancellationToken cancellationToken);
    public Task UpdateAsync(Device device, CancellationToken cancellationToken);
    public Task DeleteAsync(Device device, CancellationToken cancellationToken);
}
