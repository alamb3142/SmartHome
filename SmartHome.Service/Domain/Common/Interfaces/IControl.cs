namespace Domain.Common;

public interface IControl
{
    public int Id { get; }
    public int DeviceId { get; }
    public string Name { get; }
}