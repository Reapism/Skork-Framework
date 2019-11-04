namespace Skork.Domain.Interfaces.Models
{
    public interface IProfile
    {
        int ProfileId { get; set; }

        int UserId { get; set; }
        string PreferencesAsXml { get; set; }
    }
}
