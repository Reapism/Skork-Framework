namespace Skork.Domain.Interfaces.Computer.HDD
{
    public interface IHdd : IModel
    {
        int HddId { get; set; }

        string TotalSpace { get; set; }

    }
}
