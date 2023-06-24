using MediatR;

namespace Application.Devices;
public class PairDeviceCommand : IRequest<string>
{
    public int DeviceId { get; set; }
    public string Name { get; set; }
}
