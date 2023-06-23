using Domain.Devices;
using MediatR;

namespace Domain;

public class DeviceRegisteredDomainEvent : INotification
{
    private Device _device { get; }
    public int DeviceId => _device.Id;

    public DeviceRegisteredDomainEvent(Device device)
    {
        _device = device;
    }
}
