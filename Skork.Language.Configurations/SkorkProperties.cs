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

        public static int ActiveEntityInstances { get => activeEntityInstances; set => activeEntityInstances = value; }

        public static int MaximumEntityInstances { get; set; }

        public static int ActiveSpriteInstances { get => activeSpriteInstances; set => activeSpriteInstances = value; }

        public static int MaximumSpriteInstances { get; set; }

        public static int SpriteWidth { get; set; }

        public static int SpriteHeight { get; set; }

    }
}
