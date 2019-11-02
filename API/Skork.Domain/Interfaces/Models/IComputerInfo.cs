using Skork.Domain.Interfaces.Computer.CPU;
using Skork.Domain.Interfaces.Computer.GPU;
using Skork.Domain.Interfaces.Computer.HDD;
using Skork.Domain.Interfaces.Computer.RAM;
using Skork.Domain.Interfaces.Computer.SSD;

namespace Skork.Domain.Interfaces
{
    public interface IComputerInfo : ICpu, IGpu, IHdd, IRam, ISsd, ICreationModification
    {
        int ComputerInfoId { get; set; }
        string ComputerName { get; set; }
    }
}
