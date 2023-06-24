namespace Application.Devices;

public class DeviceDetailsResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ConnectionStatus { get; set; }
    public DateTime StatusLastCheckedUtc { get; set; }
    public List<DevicesDetailsResponseControl> Controls { get; set; }
}