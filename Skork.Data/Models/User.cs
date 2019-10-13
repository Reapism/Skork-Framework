using Skork.Data.Interfaces;
using System;

namespace Skork.Data.Models
{
    public class User : IModification, IModifiyBy
    {
        public int UserId { get; protected set; }
        public string UserRole { get; protected set; }
        public string Username { get; protected set; }
        public string Password { get; protected set; }
        public string PasswordOld { get; protected set; }
        public int NumberOfPasswordChanges { get; protected set; }
        public bool IsLocked { get; protected set; }
        public int NumberOfLoginAttempts { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime DateModified { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsModified { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
