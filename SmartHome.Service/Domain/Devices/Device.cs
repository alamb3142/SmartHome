using Domain.Common;
using FluentResults;

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

        AddDomainEvent(new DeviceRegisteredDomainEvent(this));
    }

    public static Device Create(string name)
    {
        var state = DeviceStatus.Create();
        var controls = new List<int>();
        return new Device(default, name, state, controls);
    }

    // Temporary
    public static Device Create(int id, string name)
    {
        var state = DeviceStatus.Create();
        var controls = new List<int>();
        return new Device(id, name, state, controls);
    }

    public void Rename(string name)
    {
        Name = name;
    }

    public Result SetControls(IEnumerable<int> controls)
    {
        if (_controls.Any())
            return Result.Fail("Cannot change controls after initial pairing");

        _controls = controls.ToList();

        return Result.Ok();
    }

    public void UpdateConnectionState(ConnectionState state)
    {
        Status = DeviceStatus.Create(state);
    }
}
