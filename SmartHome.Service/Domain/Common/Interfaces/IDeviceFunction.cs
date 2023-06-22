namespace Domain.Common;

public interface IDevice
{
    public Guid Id { get; }
    public DeviceState State { get; }
}