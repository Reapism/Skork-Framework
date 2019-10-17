namespace Skork.Language.Configurations
{
    /// <summary>
    /// Represents the current <see cref="SkorkProperties"/> used throughout
    /// the program.
    /// <para>Access this instance by invoke the static <see cref="Instance"/> property.</para>
    /// </summary>
    public sealed class SkorkProperties : IEntityProperties, ISpriteProperties
    {
        #region Instance/Static members

        /// <summary>
        /// Retrieves the only instance of <see cref="SkorkProperties"/>.
        /// <para><see cref="Instance"/> is a singleton.</para>
        /// </summary>
        public static SkorkProperties Instance { get => SkorkPropertiesNested.Instance; }

        #endregion

        #region Nested class for creating the singleton.

        private class SkorkPropertiesNested
        {
            internal static readonly SkorkProperties Instance = new SkorkProperties();

            static SkorkPropertiesNested()
            {
                // explicity static ctor to tell compiler to initialize
                // the static field first.
            }
        }

        #endregion

        #region Constructor(s)

        private SkorkProperties()
        {
        }

        #endregion

        #region Properties

        public int ActiveEntityInstances { get; set; }
        public int MaximumEntityInstances { get; set; }
        public int ActiveSpriteInstances { get; set; }
        public int MaximumSpriteInstances { get; set; }
        public int SpriteWidth { get; set; }
        public int SpriteHeight { get; set; }

        #endregion
    }
}