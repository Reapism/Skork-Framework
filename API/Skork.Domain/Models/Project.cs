using Skork.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace Skork.Domain.Models
{
    public class Project : IProject, ICreationModification
    {
        [Key]
        public int ProjectId { get; set; }
        public string Name { get; set; }
        [Timestamp]
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        [Timestamp]
        public DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
    }
}