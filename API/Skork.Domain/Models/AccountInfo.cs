using Skork.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace Skork.Domain.Models
{
    public class AccountInfo : IAccountInfo, ICreationModification
    {
        [Key]
        public int AccountInfoId { get; set; }
        [MaxLength]
        public string PreferencesAsXml { get; set; }
        [Timestamp]
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        [Timestamp]
        public DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
    }
}