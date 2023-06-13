using Domain.Common;
using Domain.Devices;

namespace Domain.Doorlocks;

public class DoorLock : IAggregateRoot, IDeviceFunction
{
    public Guid Id { get; protected set; }
    public Guid DeviceId { get; protected set; }
    public bool Locked { get; protected set; }

    protected DoorLock(Guid id, Guid deviceId, bool locked)
    {
        Id = id;
        DeviceId = deviceId;
        Locked = locked;
    }

    public static DoorLock Create(Device device, bool locked)
    {
        if (device.State != DeviceState.Connected)
        {
            throw new Exception("Device must be available and charged");
        }

        var doorLockId = Guid.NewGuid();

        return new DoorLock(doorLockId, device.Id, locked);
    }

    public void Lock()
    {
        Locked = true;
    }

    public void UnLock()
    {
        Locked = false;
    }
}