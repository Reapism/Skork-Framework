using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace Skork_Engine_Library.skork {
    public class SkorkSprite {

        private string name;
        private Image spriteImg;
        private Point position;

        private static int ACTIVE_SPRITE_INSTANCES;

        static SkorkSprite() {
            ACTIVE_SPRITE_INSTANCES = 0;
        }

        public SkorkSprite(string name) : this(name, new Point(0, 0)) {

        }

        public SkorkSprite(string name, Point position) {
            this.name = name;
            this.position = position;
            this.spriteImg = new Image();

            if (ACTIVE_SPRITE_INSTANCES ==) {
                Interlocked.Increment(ref ACTIVE_SPRITE_INSTANCES);
            }
        }

        /// <summary>
        /// When the garbage collector <see cref="SkorkSprite"/> invokes
        /// this destructor, it decrements the number of active sprite instances.
        /// </summary>
       ~SkorkSprite() {
            Interlocked.Decrement(ref ACTIVE_SPRITE_INSTANCES);
        }

        /// <summary>
        /// Returns the current number of active sprite instances.
        /// </summary>
        public int GetActiveSpriteInstances {
            get => ACTIVE_SPRITE_INSTANCES;
        }
    }
}
