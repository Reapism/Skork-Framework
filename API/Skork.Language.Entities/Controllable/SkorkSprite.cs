using SkiaSharp;
using Skork.Language.Configurations;
using Skork.Language.Entities.Template;
using SkorkEngine.Exceptions.Runtime.Entity;
using System.Drawing;
using System.Threading;

namespace Skork.Language.Entities.Controllable
{
    /// <summary>
    /// The <see cref="SkorkSprite"/> class.
    /// <para>Represents a single instance of a Sprite.</para>
    /// Implements <seealso cref="ISkorkEntity"/>,
    /// <seealso cref="ISkorkMovable{Entity}"/>.
    /// </summary>
    public class SkorkSprite : ISkorkMovable<ISkorkEntity>
    {
        /// <summary>
        /// The name of the sprite.
        /// <para>Implemented from <see cref="ISkorkEntity"/>.</para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The postion of the sprite as a <see cref="Point"/> type.
        /// <para>Implemented from <see cref="ISkorkEntity"/>.</para>
        /// </summary>
        public Point Position { get; set; }

        /// <summary>
        /// The display image for the sprite. Can be colors or
        /// any extension of the <see cref="Image"/> type.
        /// </summary>
        public SKBitmap SpriteImage { get; set; }

        /// <summary>
        /// When the garbage collector <see cref="SkorkSprite"/> invokes
        /// this destructor, it decrements the number of active sprite instances.
        /// </summary>
        ~SkorkSprite()
        {
            int activeSpriteInstances = SkorkEntityProperties.Instance.ActiveSpriteInstances;
            SkorkEntityProperties.Instance.ActiveSpriteInstances = Interlocked.Decrement(ref activeSpriteInstances);
        }

        /// <summary>
        /// Initializes the a <see cref="SkorkSprite"/> instance with a
        /// <paramref name="name"/> and <paramref name="position"/>.
        /// </summary>
        /// <param name="name">The name of the sprite.</param>
        /// <param name="position">The position of the sprite.</param>
        /// <param name="color">The color of the sprite to add.</param>
        public SkorkSprite(string name, Point position, Color color)
        {
            Name = name;
            Position = position;

            SpriteImage = new SKBitmap(
                new SKImageInfo(
                    SkorkEntityProperties.Instance.SpriteWidth,
                    SkorkEntityProperties.Instance.SpriteHeight,
                    SKColorType.Alpha8,
                    SKAlphaType.Premul
                )
            );

            if (SkorkEntityProperties.Instance.ActiveSpriteInstances != SkorkEntityProperties.Instance.MaximumEntityInstances)
            {
                int activeSpriteInstances = SkorkEntityProperties.Instance.ActiveSpriteInstances;
                SkorkEntityProperties.Instance.ActiveSpriteInstances = Interlocked.Increment(ref activeSpriteInstances);
            }
            else
            {
                throw new SkorkSpriteOverflowException($"Exceeded the maximum number of active sprites:" +
                    $" { SkorkEntityProperties.Instance.MaximumEntityInstances }.");
            }
        }

        /// <summary>
        /// Move this <see cref="SkorkSprite"/> instance up 
        /// by (<see langword="N"/>) units.
        /// </summary>
        /// <param name="entity">The entity to move.</param>
        /// <param name="units">The amount of units to move the entity by.</param>
        public void Up(ISkorkEntity entity, int units)
        {
            entity.Position = new Point(entity.Position.X, entity.Position.Y + units);
        }

        /// <summary>
        /// Move this <see cref="SkorkSprite"/> instance down 
        /// by (<see langword="N"/>) units.
        /// </summary>
        /// <param name="entity">The entity to move.</param>
        /// <param name="units">The amount of units to move the entity by.</param>
        public void Down(ISkorkEntity entity, int units)
        {
            entity.Position = new Point(entity.Position.X, entity.Position.Y - units);
        }

        /// <summary>
        /// Move this <see cref="SkorkSprite"/> instance left 
        /// by (<see langword="N"/>) units.
        /// </summary>
        /// <param name="entity">The entity to move.</param>
        /// <param name="units">The amount of units to move the entity by.</param>
        public void Left(ISkorkEntity entity, int units)
        {
            entity.Position = new Point(entity.Position.X - units, entity.Position.Y);
        }

        /// <summary>
        /// Move this <see cref="SkorkSprite"/> instance right 
        /// by (<see langword="N"/>) units.
        /// </summary>
        /// <param name="entity">The entity to move.</param>
        /// <param name="units">The amount of units to move the entity by.</param>
        public void Right(ISkorkEntity entity, int units)
        {
            entity.Position = new Point(entity.Position.X + units, entity.Position.Y);
        }

        /// <summary>
        /// Returns a string describing this <see cref="SkorkSprite"/>
        /// instance.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"I am a {SpriteImage} Sprite named {Name} located at {Position.ToString()}";
        }

        /// <summary>
        /// If the <see cref="Name"/>, <see cref="Position"/>, 
        /// and <see cref="SpriteImage"/> are the same, then the two sprites
        /// are equal.
        /// </summary>
        /// <param name="obj">The object to compare to this instance.</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is SkorkSprite sprite)
            {
                if (Name.Equals(sprite.Name) &&
                        Position.Equals(sprite.Position) &&
                        SpriteImage.Equals(sprite.SpriteImage))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Returns a hashcode using unique primes.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            int prime = 17;
            int prime2 = 23;
            return prime * prime2 + Name.GetHashCode() + prime * prime2 + SpriteImage.GetHashCode();
        }
    }
}
