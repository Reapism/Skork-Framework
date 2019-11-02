using Skork.Domain.Interfaces;

namespace Skork.Domain.Models
{
    public class ComputerInfo : IComputerInfo
    {
        public int ComputerInfoId { get; set; }
        public string ComputerName { get; set; }
    }
}