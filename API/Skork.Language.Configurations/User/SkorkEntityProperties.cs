namespace Skork.Language.Configurations
{
    /// <summary>
    /// Represents the current <see cref="SkorkEntityProperties"/> used throughout
    /// the program.
    /// <para>Access this instance by invoking the static <see cref="Instance"/> property.</para>
    /// </summary>
    public sealed class SkorkEntityProperties : IEntityProperties, ISpriteProperties
    {
        /// <summary>
        /// Retrieves the only instance of <see cref="SkorkEntityProperties"/>.
        /// <para><see cref="Instance"/> is a singleton.</para>
        /// </summary>
        public static SkorkEntityProperties Instance => SkorkEntityPropertiesNested.Instance;

        private class SkorkEntityPropertiesNested
        {
            internal static readonly SkorkEntityProperties Instance = new SkorkEntityProperties();

            static SkorkEntityPropertiesNested()
            {
                // explicity static ctor to tell compiler to initialize
                // the static field first.
            }
        }

        private SkorkEntityProperties()
        {
        }

        public int ActiveEntityInstances { get; set; }
        public int MaximumEntityInstances { get; set; }
        public int ActiveSpriteInstances { get; set; }
        public int MaximumSpriteInstances { get; set; }
        public int SpriteWidth { get; set; }
        public int SpriteHeight { get; set; }
    }
}