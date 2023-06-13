using Domain.Devices;
using Domain.Doorlocks;

namespace Domain.UnitTests;

[TestFixture]
public class DoorLockTests
{
    [Test]
    public void Test1()
    {
        var device = Device.Create("1234", true, DeviceState.Connected);
        var doorLock = DoorLock.Create(device, false);

        doorLock.DeviceId.Should().Be(device.Id);
        doorLock.Locked.Should().Be(false);
    }
}