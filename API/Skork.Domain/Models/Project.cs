using Skork.Domain.Interfaces;
using System;

namespace Skork.Domain.Models
{
    public class Project : IProject, ICreationModification
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
    }
}