using Domain.Common;
using Domain.Devices;

namespace Domain.Switches;
public class Switch : Entity, IAggregateRoot, IControl
{
    public int DeviceId { get; protected set; }
    public string Name { get; protected set; } = "";
    public SwitchState State { get; protected set; }

    protected Switch(int id, int devicedId, SwitchState state)
    {
        Id = id;
        DeviceId = devicedId;
        State = state;
    }

    public static Switch Create(Device device, SwitchState state)
    {
        return new Switch(default, device.Id, state);
    }

    public void On()
    {
        State = SwitchState.On;
    }

    public void Off()
    {
        State = SwitchState.Off;
    }

    // Example of how we could deal with invariants around device status
    public void Flip(Device device)
    {
        var connection = device.Status.ConnectionState;
        var deviceNotAvailable = connection == ConnectionState.Disconnected || connection == ConnectionState.Unkown;

        if (deviceNotAvailable)
        {
            throw new InvalidOperationException($"Cannot switch when device is {nameof(connection)}");
        }

        State = State switch
        {
            SwitchState.On => SwitchState.Off,
            SwitchState.Off => SwitchState.On,
            _ => throw new NotImplementedException(),
        };
    }
}
