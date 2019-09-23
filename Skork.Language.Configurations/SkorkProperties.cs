namespace Skork.Language.Configurations
{
    public sealed class SkorkProperties
    {
        /// <summary>
        /// Retrieves single instance of <see cref="SkorkProperties"/>.
        /// <para></para>
        /// </summary>
        public static SkorkProperties Instance { get => SkorkPropertiesNested.Instance; }

        private SkorkProperties()
        {
        }

        private class SkorkPropertiesNested
        {
            internal static readonly SkorkProperties Instance = new SkorkProperties();
            
            static SkorkPropertiesNested()
            {
                // intentionally left blank for compiler.
            }
        }
    }
}
