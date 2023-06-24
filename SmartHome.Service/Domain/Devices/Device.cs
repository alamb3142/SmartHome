using Domain.Common;

namespace Domain.Devices;

public class Device : Entity, IAggregateRoot
{
    public string Name { get; protected set; }
    public DeviceStatus Status { get; protected set; }
    public IReadOnlyCollection<int> Controls => _controls.AsReadOnly();

    private List<int> _controls = new();

    protected Device(int id, string name, DeviceStatus deviceStatus, IEnumerable<int> controls)
    {
        Id = id;
        Name = name;
        Status = deviceStatus;
        _controls = controls.ToList();

        //? So I think we pass it the device, the entity gets saved, ID is updated in the 
        //? reference, then after saveChanges we get the ID from that reference out of the event?
        AddDomainEvent(new DeviceRegisteredDomainEvent(this));
    }

    public static Device Create(string name)
    {
        var state = new DeviceStatus(ConnectionState.Unkown, DateTime.UtcNow);
        var controls = new List<int>();
        return new Device(default, name, state, controls);
    }

    // Temporary
    public static Device Create(int id, string name)
    {
        var state = new DeviceStatus(ConnectionState.Unkown, DateTime.UtcNow);
        var controls = new List<int>();
        return new Device(id, name, state, controls);
    }

    public void Rename(string name)
    {
        Name = name;
    }

    public void SetControls(IEnumerable<int> controls)
    {
        _controls = controls.ToList();
    }

    public void UpdateConnectionState(ConnectionState state)
    {
        Status = new DeviceStatus(state, DateTime.UtcNow);
    }
}
