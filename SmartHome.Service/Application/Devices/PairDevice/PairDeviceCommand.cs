using MediatR;

namespace Application.Devices;
public class PairDeviceCommand : IRequest<string>
{
    public string Name { get; set; }
    public string QRCode { get; set; }
}
