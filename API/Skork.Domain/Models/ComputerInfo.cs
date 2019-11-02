using System;
using System.ComponentModel.DataAnnotations;
using Skork.Domain.Interfaces;

namespace Skork.Domain.Models
{
    public class ComputerInfo : IComputerInfo
    {
        public int ComputerInfoId { get; set; }
        public string ComputerName { get; set; }

        public int CpuId { get; set; }
        public string CpuName { get; set; }
        public string CpuSpeed { get; set; }
        public string CpuL1Cache { get; set; }
        public string CpuL2Cache { get; set; }
        public string CpuL3Cache { get; set; }
        public string CpuNumberOfCores { get; set; }
        public string CpuNumberOfThreads { get; set; }

        public int GpuId { get; set; }
        public string GpuName { get; set; }
        public string GpuSpeed { get; set; }
        public string GpuDedicatedMemory { get; set; }
        public string GpuDriverVersion { get; set; }

        public int HddId { get; set; }
        public string HddName { get; set; }
        public string HddSpeed { get; set; }
        public string HddTotalSpace { get; set; }

        public int RamId { get; set; }
        public string RamName { get; set; }
        public string RamSpeed { get; set; }
        public string RamCapacity { get; set; }

        public int SsdId { get; set; }
        public string SsdName { get; set; }
        public string SsdSpeed { get; set; }
        public string SsdCapacity { get; set; }

        [Timestamp]
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        [Timestamp]
        public DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
    }
}