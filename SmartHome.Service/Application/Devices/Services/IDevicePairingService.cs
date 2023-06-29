using FluentResults;

namespace Application.Devices;

public interface IDevicePairingService
{
    /// <summary>Start the pairing process using the device's QR code</summary>
    /// <returns>Guid task id for tracking pairing status</returns>
    public Task<Result<Guid>> StartPairingAsync(string qrCode, CancellationToken cancellationToken);

    public Task<string> GetPairingStatus(Guid taskId);
}

// Stub implementations
public class DevicePairingService : IDevicePairingService
{
    public Task<string> GetPairingStatus(Guid taskId)
    {
        throw new NotImplementedException();
    }

    public Task<Result<Guid>> StartPairingAsync(string qrCode, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}