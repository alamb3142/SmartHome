using System.Data.Common;
using Domain;
using MediatR;

namespace Application.Devices;

public class GetDevicesQueryHandler : IRequestHandler<GetDevicesQuery, List<DeviceDetailsResponse>>
{
    private readonly IDeviceRepository _repository;

    public GetDevicesQueryHandler(IDeviceRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<DeviceDetailsResponse>> Handle(GetDevicesQuery request, CancellationToken cancellationToken)
    {
        var devices = await _repository.GetAllAsync(cancellationToken);

        // TODO fluent mappers
        var response = devices.Select(device => new DeviceDetailsResponse()
        {
            Id = device.Id,
            Name = device.Name,
            ConnectionStatus = device.Status.ConnectionState.ToString(),
            StatusLastCheckedUtc = device.Status.LastCheckedUtc,
            Controls = device.Controls.Select(control => new DevicesDetailsResponseControl()
            {
                Id = control,
                Name = "Test"
            }).ToList()
        }).ToList();

        return response;

    }
}