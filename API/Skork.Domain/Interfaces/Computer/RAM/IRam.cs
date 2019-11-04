namespace Skork.Domain.Interfaces.Computer.RAM
{
    public interface IRam
    {
        int RamId { get; set; }

        string RamName { get; set; }
        string RamSpeed { get; set; }
        string RamCapacity { get; set; }
    }
}
