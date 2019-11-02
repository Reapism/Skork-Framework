using Skork.Domain.Interfaces.Base;

namespace Skork.Domain.Interfaces.Computer.RAM
{
    public interface IRam : IModel, ISpeed
    {
        int RamId { get; set; }
    }
}
