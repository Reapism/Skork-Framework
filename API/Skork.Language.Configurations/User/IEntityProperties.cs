namespace Skork.Language.Configurations
{
    /// <summary>
    /// Represents generalized properties for an Entity.
    /// </summary>
    public interface IEntityProperties
    {
        /// <summary>
        /// Represents the number of active entity instances in a given context.
        /// </summary>
        int ActiveEntityInstances { get; set; }

        /// <summary>
        /// Represents the maximum number of active entity instances in a given context.
        /// </summary>
        int MaximumEntityInstances { get; set; }
    }
}
