using System.ComponentModel.DataAnnotations;

namespace Skork.Data.Interfaces
{
    public interface ICreated
    {
        [Timestamp]
        byte[] TimeCreated { get; set; }

        string CreatedBy { get; set; }
    }
}
