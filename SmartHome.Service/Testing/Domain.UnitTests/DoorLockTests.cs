using Domain.Devices;
using Domain.Doorlocks;

namespace Domain.UnitTests;

[TestFixture]
public class DoorLockTests
{
    private Device _activeDevice;

    [SetUp]
    public void Setup()
    {
        _activeDevice = Device.Create("1234", true, DeviceState.Connected);
    }

    [Test]
    public void Create_WithActiveDevice_ReturnsNewDoorLock()
    {
        var device = Device.Create("1234", true, DeviceState.Connected);
        var doorLock = DoorLock.Create(device, false);

        doorLock.DeviceId.Should().Be(device.Id);
        doorLock.Locked.Should().Be(false);
    }

    [Test]
    public void Create_WithDisconnectedDevice_ThrowsException()
    {
        var device = Device.Create("1234", true, DeviceState.Disconnected);
        Action create = () => DoorLock.Create(device, false);

        create.Should().Throw<Exception>();
    }

    [Test]
    public void Lock_WithUnlockedDoor_LocksDoor()
    {
        var doorLock = DoorLock.Create(_activeDevice, false);
        doorLock.Lock();
        doorLock.Locked.Should().Be(true);
    }

    [Test]
    public void Lock_WithLockedDoor_UnlocksDoor()
    {
        var doorLock = DoorLock.Create(_activeDevice, true);
        doorLock.UnLock();
        doorLock.Locked.Should().Be(false);
    }
}