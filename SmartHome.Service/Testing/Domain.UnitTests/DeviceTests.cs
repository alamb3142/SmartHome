using Domain.Devices;

namespace Domain.UnitTests;

public class DeviceTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Create_ReturnsValidDevice()
    {
        var device = Device.Create("1234", true, DeviceState.Connected);
        Assert.That(device.Id != Guid.Empty);
        Assert.That(device.On == true);
        Assert.That(device.NodeId == "1234");
        Assert.That(device.State == DeviceState.Connected);
    }
}