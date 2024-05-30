using Domain.Abstraction;

namespace Domain.Abstraction
{
    public abstract class Entity
    {
        public Guid Uuid { get; init; }

        private readonly List<IDomainEvent> _domainEvents = new();

        protected Entity(Guid uuid)
        {
            Uuid = uuid;
        }

        protected Entity()
        {
        }

        public IReadOnlyList<IDomainEvent> GetDomainEvents()
        {
            return _domainEvents.ToList();
        }

        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }

        protected void RaiseDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }
    }
}
