using MediatR;

namespace Application.Devices;

public class GetDevicesQuery : IRequest<List<DeviceDetailsResponse>>
{
    public int? FetchNum { get; set; } = 50;
    public int? OffSet { get; set; } = 0;
}