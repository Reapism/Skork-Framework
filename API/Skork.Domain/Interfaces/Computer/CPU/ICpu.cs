using Skork.Domain.Interfaces.Base;

namespace Skork.Domain.Interfaces.Computer.CPU
{
    public interface ICpu : IModel, ISpeed
    {
        int CpuId { get; set; }

        string L1Cache { get; set; }
        string L2Cache { get; set; }
        string L3Cache { get; set; }
        string NumberOfCores { get; set; }
        string NumberOfThreads { get; set; }
    }
}
