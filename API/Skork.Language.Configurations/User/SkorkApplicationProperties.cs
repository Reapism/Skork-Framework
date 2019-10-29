namespace Skork.Language.Configurations.User
{
    public class SkorkApplicationProperties
    {
        /// <summary>
        /// Retrieves the only instance of <see cref="SkorkApplicationProperties"/>.
        /// <para><see cref="Instance"/> is a singleton.</para>
        /// </summary>
        public static SkorkApplicationProperties Instance => SkorkApplicationPropertiesNested.Instance;

        private class SkorkApplicationPropertiesNested
        {
            internal static readonly SkorkApplicationProperties Instance = new SkorkApplicationProperties();

            static SkorkApplicationPropertiesNested()
            { }
        }

        private SkorkApplicationProperties()
        {
        }

    }
}
