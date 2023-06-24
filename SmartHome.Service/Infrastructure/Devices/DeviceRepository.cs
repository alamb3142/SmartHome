using Domain;
using Domain.Common;
using Domain.Devices;

namespace Infrastructure.Devices;

public class DeviceRepository : IDeviceRepository
{
    private List<Device> _deviceCache;
    private int _lastId = 1;
    public int NewId => _lastId++;

    public DeviceRepository()
    {
        _deviceCache = new List<Device>();
    }

    public Task AddAsync(Device device, CancellationToken cancellationToken)
    {
        _deviceCache.Add(device);
        return Task.CompletedTask;
    }

    public Task DeleteAsync(Device device, CancellationToken cancellationToken)
    {
        // Should do the equality comparisons defined in Entity to figure 
        // out which one to get rid of
        _deviceCache.Remove(device);
        return Task.CompletedTask;
    }

    public async Task<List<Device>> GetAllAsync(CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        return _deviceCache;
    }

    public async Task<List<Device>> GetByControlId(int controlId, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        return _deviceCache.Where(x => x.Controls.Any(id => id == controlId)).ToList();
    }

    public Task<List<Device>> GetByControlId(IEnumerable<int> controlIds, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Device> GetById(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<List<Device>> GetById(IEnumerable<int> ids, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Device device, CancellationToken cancellationToken)
    {
        var existing = _deviceCache.First(x => x.Id == device.Id);
        _deviceCache.Remove(existing);
        _deviceCache.Add(device);
        return Task.CompletedTask;
    }
}