
using StudyCareVisteService.Abstraction.DomainEvent;
using StudyCareVisteService.Abstraction.Entity;

namespace StudyCareVisteService.Abstraction.Aggregate
{
    public interface IAggregate<T>:  IAggregate, IEntity<T>
    {
    }
    public interface IAggregate : IEntity
    {
        IReadOnlyList<IDomainEvent> DomainEvents { get; }
        IDomainEvent[] ClearDomainEvents();
    }
}
