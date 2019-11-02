using System;
using System.ComponentModel.DataAnnotations;
using Skork.Domain.Interfaces;

namespace Skork.Domain.Models
{
    public class ComputerInfo : IComputerInfo
    {
        [Required]
        public int ComputerInfoId { get; set; }
        [Display(Name = "Computer")]
        public string ComputerName { get; set; }

        [Required]
        public int CpuId { get; set; }
        [Display(Name = "Processor")]
        public string CpuName { get; set; }
        [Display(Name = "Speed")]
        public string CpuSpeed { get; set; }
        [Display(Name = "L1 Cache")]
        public string CpuL1Cache { get; set; }
        [Display(Name = "L2 Cache")]
        public string CpuL2Cache { get; set; }
        [Display(Name = "L3 Cache")]
        public string CpuL3Cache { get; set; }
        [Display(Name = "Cores")]
        public string CpuNumberOfCores { get; set; }
        [Display(Name = "Threads")]
        public string CpuNumberOfThreads { get; set; }

        [Required]
        public int GpuId { get; set; }
        [Display(Name = "Graphics Card")]
        public string GpuName { get; set; }
        [Display(Name = "Speed")]
        public string GpuSpeed { get; set; }
        [Display(Name = "Dedicated Memory")]
        public string GpuDedicatedMemory { get; set; }
        [Display(Name = "Driver Version")]
        public string GpuDriverVersion { get; set; }

        [Required]
        public int HddId { get; set; }
        [Display(Name = "Hard Drive")]
        public string HddName { get; set; }
        [Display(Name = "Speed")]
        public string HddSpeed { get; set; }
        [Display(Name = "Total Capacity")]
        public string HddTotalSpace { get; set; }

        [Required]
        public int RamId { get; set; }
        [Display(Name = "Ram")]
        public string RamName { get; set; }
        [Display(Name = "Speed")]
        public string RamSpeed { get; set; }
        [Display(Name = "Capacity")]
        public string RamCapacity { get; set; }

        [Required]
        public int SsdId { get; set; }
        [Display(Name = "Solid State Drive")]
        public string SsdName { get; set; }
        [Display(Name = "Speed")]
        public string SsdSpeed { get; set; }
        [Display(Name = "Total Capacity")]
        public string SsdCapacity { get; set; }

        [Timestamp]
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }     
        [Timestamp]
        public DateTime LastModified { get; set; }     
        public string ModifiedBy { get; set; }
    }
}
