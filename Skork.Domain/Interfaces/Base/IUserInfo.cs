using System;

namespace Skork.Domain.Interfaces
{
    public interface IUserInfo
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        DateTime DateOfBirth { get; set; }
    }
}
