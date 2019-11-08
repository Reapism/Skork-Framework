using Skork.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace Skork.Domain.Models
{
    public class User : IUser, ICreationModification
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordOld { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Timestamp]
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        [Timestamp]
        public DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
    }
}