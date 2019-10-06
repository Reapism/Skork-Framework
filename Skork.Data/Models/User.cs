using Skork.Data.Interfaces;
using System;

namespace Skork.Data.Models
{
    public class User : IModification, IModifiyBy
    {
        public int UserId { get; set; }
        public string UserRole { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordOld { get; set; }
        public int NumberOfPasswordChanges { get; set; }




        public DateTime DateModified { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsModified { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
