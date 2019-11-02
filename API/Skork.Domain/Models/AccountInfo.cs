using Skork.Domain.Interfaces;
using System;

namespace Skork.Domain.Models
{
    public class AccountInfo : IAccountInfo, ICreationModification
    {
        public int AccountInfoId { get; set; }
        public string PreferencesAsXml { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
    }
}