using Skork.Domain.Interfaces.Base;

namespace Skork.Domain.Interfaces.Computer.GPU
{
    public interface IGpu : IModel, IDriverInfo
    {
        int GpuId { get; set; }
    }
}
