namespace Skork.Domain.Interfaces
{
    public interface IUser : IUserAccount
    {
        int UserId { get; set; }
    }
}
