using Domain;
using Domain.Devices;
using MediatR;

namespace Application.Devices;
public class PairDeviceCommandHandler : IRequestHandler<PairDeviceCommand, string>
{
    private readonly IDeviceRepository _repository;

    public PairDeviceCommandHandler(IDeviceRepository repository)
    {
        _repository = repository;
    }

    public async Task<string> Handle(PairDeviceCommand request, CancellationToken cancellationToken)
    {

        var device = Device.Create(_repository.NewId, request.Name);
        await _repository.AddAsync(device, cancellationToken);

        return $"Added device with Id: {device.Id}";
    }
}
