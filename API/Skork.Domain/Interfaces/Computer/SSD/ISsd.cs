namespace Skork.Domain.Interfaces.Computer.SSD
{
    public interface ISsd
    {
        int SsdId { get; set; }

        string SsdName { get; set; }
        string SsdSpeed { get; set; }
        string SsdCapacity { get; set; }
    }
}