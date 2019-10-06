using Skork.Data.DatabaseStructure;
using Skork.Data.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Skork.Data.Models
{
    public class Project : ICreated
    {
        // todo: fix to use enum in DatabaseTables
        private const string USER = "User";

        public int ProjectId { get; set; }

        [ForeignKey(USER)]
        public int UserId { get; set; }

        public string ProjectName { get; set; }

        [Timestamp]
        public byte[] TimeCreated { get; set; }

        public string CreatedBy { get; set; }
    }
}
