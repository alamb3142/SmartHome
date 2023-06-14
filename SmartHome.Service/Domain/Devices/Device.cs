using Domain.Common;

namespace Domain.Devices;

public class Device : Entity, IAggregateRoot
{
    public string NodeId { get; protected set; } //? value object?
    public bool On { get; protected set; }
    public DeviceState State { get; protected set; }

    protected Device(Guid id, string nodeId, bool on, DeviceState state)
    {
        Id = id;
        NodeId = nodeId;
        On = on;
        State = state;
    }

    public static Device Create(string nodeId, bool on, DeviceState state)
    {
        var id = Guid.NewGuid();
        return new Device(id, nodeId, on, state);
    }

    public void Switch(bool on)
    {
        On = on;
    }
}