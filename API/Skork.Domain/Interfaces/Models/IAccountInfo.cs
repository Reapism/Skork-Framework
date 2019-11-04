namespace Skork.Domain.Interfaces
{
    public interface IAccountInfo
    {
        int AccountInfoId { get; set; }

        string PreferencesAsXml { get; set; }
    }
}
