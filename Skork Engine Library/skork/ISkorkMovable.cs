namespace Skork_Engine_Library.Skork
{

    /// <summary>
    /// The <see cref="ISkorkMovable{Entity}"/> interface.
    /// <para>Four methods for moving a <see cref="ISkorkEntity"/> in a 
    /// direction.</para>
    /// <para>This interface <see langword="enforces"/> its type argument
    /// to be of type <see cref="ISkorkEntity"/>.</para>
    /// </summary>
    public interface ISkorkMovable<Entity> where Entity : ISkorkEntity
    {

        /// <summary>
        /// Moves a particular <see cref="ISkorkEntity"/>
        /// upwards by <see langword="N"/> <paramref name="units"/>.
        /// </summary>
        /// <param name="entity">Any <see cref="ISkorkEntity"/> derived object.</param>
        /// <param name="units">Amount of units to move the <see cref="ISkorkEntity"/>.</param>
        void Up(Entity entity, int units);

        /// <summary>
        /// Moves a particular <see cref="ISkorkEntity"/>
        /// downwards by <see langword="N"/> <paramref name="units"/>.
        /// </summary>
        /// <param name="entity">Any <see cref="ISkorkEntity"/> derived object.</param>
        /// <param name="units">Amount of units to move the <see cref="ISkorkEntity"/>.</param>
        void Down(Entity entity, int units);

        /// <summary>
        /// Moves a particular <see cref="ISkorkEntity"/>
        /// left by <see langword="N"/> <paramref name="units"/>.
        /// </summary>
        /// <param name="entity">Any <see cref="ISkorkEntity"/> derived object.</param>
        /// <param name="units">Amount of units to move the <see cref="ISkorkEntity"/>.</param>
        void Left(Entity entity, int units);

        /// <summary>
        /// Moves a particular <see cref="ISkorkEntity"/>
        /// right by <see langword="N"/> <paramref name="units"/>.
        /// </summary>
        /// <param name="entity">Any <see cref="ISkorkEntity"/> derived object.</param>
        /// <param name="units">Amount of units to move the <see cref="ISkorkEntity"/>.</param>
        void Right(Entity entity, int units);

    }
}
