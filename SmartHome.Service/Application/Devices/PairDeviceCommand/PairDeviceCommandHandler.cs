using MediatR;

namespace Application.Devices;
public class PairDeviceCommandHandler : IRequestHandler<PairDeviceCommand, string>
{
    public Task<string> Handle(PairDeviceCommand request, CancellationToken cancellationToken)
    {
        return Task.Run(() => $"Requested pairing for device id: {request.DeviceId}");
    }
}
