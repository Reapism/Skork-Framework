namespace Skork.Language.Configurations
{
    public static class SkorkProperties
    {
        static SkorkProperties()
        {
            activeEntityInstances = 0;
            activeSpriteInstances = 0;
        }

        private static int activeEntityInstances;
        private static int activeSpriteInstances;

        public static int ActiveEntityInstances { get { return activeEntityInstances; } set { activeEntityInstances = value; } }

        public static int MaximumEntityInstances { get; set; }

        public static int ActiveSpriteInstances { get { return activeSpriteInstances; } set { activeSpriteInstances = value; } }

        public static int MaximumSpriteInstances { get; set; }

        public static int SpriteWidth { get; set; }

        public static int SpriteHeight { get; set; }

    }
}
