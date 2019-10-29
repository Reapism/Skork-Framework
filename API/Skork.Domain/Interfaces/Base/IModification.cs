using System;

namespace Skork.Domain.Interfaces
{
    public interface IModification
    {
        DateTime LastModified { get; set; }
    }
}
