namespace Skork.Domain.Interfaces.Computer.HDD
{
    public interface IHdd
    {
        int HddId { get; set; }

        string HddName { get; set; }
        string HddSpeed { get; set; }
        string HddTotalSpace { get; set; }

    }
}
