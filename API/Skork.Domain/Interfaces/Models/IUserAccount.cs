namespace Skork.Domain.Interfaces
{
    public interface IUserAccount : IUserInfo
    {
        string Username { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        string PasswordOld { get; set; }
    }
}