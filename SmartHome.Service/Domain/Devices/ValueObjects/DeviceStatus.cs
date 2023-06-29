using Domain.Common;
using FluentResults;

namespace Domain.Devices;

public class DeviceStatus : ValueObject
{
    public ConnectionState ConnectionState { get; private set; }
    public DateTime LastCheckedUtc { get; private set; }

    private DeviceStatus(ConnectionState connectionState, DateTime lastCheckedUtc)
    {
        ConnectionState = connectionState;
        LastCheckedUtc = lastCheckedUtc;
    }

    public static DeviceStatus Create()
    {
        return new DeviceStatus(ConnectionState.Unkown, DateTime.UtcNow);
    }

    public static DeviceStatus Create(ConnectionState connectionState)
    {
        return new DeviceStatus(connectionState, DateTime.UtcNow);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return ConnectionState;
    }
}
