using Skork_Engine_Library.Skork;
using SkorkEngine.exception;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Skork_Engine_Library.skork {
    /// <summary>
    /// The <see cref="SkorkSprite"/> class.
    /// <para>Represents a single instance of a Sprite.</para>
    /// Implements <seealso cref="ISkorkEntity"/>,
    /// <seealso cref="ISkorkMovable{Entity}"/>.
    /// </summary>
    public class SkorkSprite : ISkorkEntity, ISkorkMovable<ISkorkEntity> {

        #region Instance member(s)

        #endregion

        #region Static Fields

        private static int ACTIVE_SPRITE_INSTANCES;

        #endregion

        #region Properties

        /// <summary>
        /// The name of the sprite.
        /// </summary>
        public string z { get; set; }
        public Point Position { get; set; }
        public Image SpriteImage { get; set; }

        #endregion

        #region Contructors & Destructors

        /// <summary>
        /// Initialize instances to 0.
        /// </summary>
        static SkorkSprite() {
            ACTIVE_SPRITE_INSTANCES = 0;
        }

        /// <summary>
        /// When the garbage collector <see cref="SkorkSprite"/> invokes
        /// this destructor, it decrements the number of active sprite instances.
        /// </summary>
       ~SkorkSprite() {
            Interlocked.Decrement(ref ACTIVE_SPRITE_INSTANCES);
        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="name"></param>
        public SkorkSprite(string name) : this(name, new Point(0, 0)) {

        }

        /// <summary>
        /// Initializes the a <see cref="SkorkSprite"/> instance with a
        /// <paramref name="name"/> and <paramref name="position"/>.
        /// </summary>
        /// <param name="name">The name of the sprite.</param>
        /// <param name="position">The position of the sprite.</param>
        public SkorkSprite(string name, Point position) {
            this.Name = name;
            this.Position = position;
            this.spriteImg = new Image();

            if (ACTIVE_SPRITE_INSTANCES != Properties.Settings.Default.max_sprite_instances) {
                Interlocked.Increment(ref ACTIVE_SPRITE_INSTANCES);
            } else {
                throw new SkorkSpriteOverflowException($"Exceeded the maximum number of active sprites: {Properties.Settings.Default.max_sprite_instances}.");
            }
        }

        #endregion

        #region Static methods and properties

        /// <summary>
        /// Returns the current number of active sprite instances.
        /// </summary>
        public int GetActiveSpriteInstances {
            get => ACTIVE_SPRITE_INSTANCES;
        }

        #endregion

        #region Instance methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="units"></param>
        public void Up(ISkorkEntity entity, int units) {
            if (entity is SkorkSprite) {

            }
        }

        public void Down(ISkorkEntity entity, int units) {
            throw new System.NotImplementedException();
        }

        public void Left(ISkorkEntity entity, int units) {
            throw new System.NotImplementedException();
        }

        public void Right(ISkorkEntity entity, int units) {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
