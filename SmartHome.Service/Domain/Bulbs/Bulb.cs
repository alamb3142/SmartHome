using Domain.Common;

namespace Domain.Bulbs;

public class Bulb : Entity, IAggregateRoot, IDeviceFunction
{
    public Guid DeviceId { get; protected set; }

}