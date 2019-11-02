namespace Skork.Domain.Interfaces.Computer.CPU
{
    public interface ICpu
    {
        int CpuId { get; set; }

        string CpuName { get; set; }
        string CpuSpeed { get; set; }
        string CpuL1Cache { get; set; }
        string CpuL2Cache { get; set; }
        string CpuL3Cache { get; set; }
        string CpuNumberOfCores { get; set; }
        string CpuNumberOfThreads { get; set; }
    }
}
