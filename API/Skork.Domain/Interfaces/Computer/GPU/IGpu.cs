namespace Skork.Domain.Interfaces.Computer.GPU
{
    public interface IGpu
    {
        int GpuId { get; set; }

        string GpuName { get; set; }
        string GpuSpeed { get; set; }
        string GpuDedicatedMemory { get; set; }
        string GpuDriverVersion { get; set; }
    }
}
