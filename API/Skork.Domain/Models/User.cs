using Skork.Domain.Interfaces;
using System;

namespace Skork.Domain.Models
{
    public class User : IUser
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordOld { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
