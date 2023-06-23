using Domain.Common;

namespace Domain.Devices;

public class DeviceStatus : ValueObject
{
    public ConnectionState ConnectionState { get; private set; }
    public DateTime LastCheckedUtc { get; private set; }

    public DeviceStatus(ConnectionState connectionState, DateTime lastCheckedUtc)
    {
        ConnectionState = connectionState;
        LastCheckedUtc = lastCheckedUtc;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return ConnectionState;
    }
}
