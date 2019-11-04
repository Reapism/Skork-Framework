using Skork.Domain.Interfaces.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Skork.Domain.Models
{
    public class Profile : IProfile
    {
        [Key]
        public int ProfileId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        [MaxLength]
        public string PreferencesAsXml { get; set; }
    }
}
