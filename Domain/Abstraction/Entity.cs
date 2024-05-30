namespace Domain.Abstraction
{
    public abstract class Entity
    {
        protected Entity(Guid uuid)
        {
            Uuid = uuid;
        }

        protected Entity()
        {
        }

        public Guid Uuid { get; init; }
    }
}
