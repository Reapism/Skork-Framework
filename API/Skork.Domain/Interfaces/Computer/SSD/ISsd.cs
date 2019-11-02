using Skork.Domain.Interfaces.Base;

namespace Skork.Domain.Interfaces.Computer.SSD
{
    public interface ISsd : IModel, ISpeed
    {
        int SsdId { get; set; }
    }
}