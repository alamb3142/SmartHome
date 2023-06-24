using System.Data.Common;
using MediatR;

namespace Application.Devices;

public class GetDevicesQueryHandler : IRequestHandler<GetDevicesQuery, List<DeviceDetailsResponse>>
{

    public Task<List<DeviceDetailsResponse>> Handle(GetDevicesQuery request, CancellationToken cancellationToken)
    {
        var x = new List<DeviceDetailsResponse>()
        {
            new DeviceDetailsResponse()
            {
                Id = 1,
                Name = "Smart Bulb",
                ConnectionStatus = "Available",
                StatusLastCheckedUtc = DateTime.UtcNow.AddHours(-2),
                Controls = new List<DevicesDetailsResponseControl>()
                {
                    new DevicesDetailsResponseControl()
                    {
                        Id = 1,
                        Name = "Switch"
                    }
                }
            },
            new DeviceDetailsResponse()
            {
                Id = 1,
                Name = "Dimmable Smart Bulb",
                ConnectionStatus = "Available",
                StatusLastCheckedUtc = DateTime.UtcNow.AddHours(-1),
                Controls = new List<DevicesDetailsResponseControl>()
                {
                    new DevicesDetailsResponseControl()
                    {
                        Id = 2,
                        Name = "Switch"
                    },
                    new DevicesDetailsResponseControl()
                    {
                        Id = 3,
                        Name = "Level"
                    }
                }
            }
        };

        return Task.FromResult(x.Skip(request.OffSet).Take(request.FetchNum).ToList());
    }
}