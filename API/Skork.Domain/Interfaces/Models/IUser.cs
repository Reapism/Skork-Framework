namespace Skork.Domain.Interfaces
{
    public interface IUser : IUserAccount, ICreationModification
    {
        int UserId { get; set; }
    }
}
