using Domain.Abstraction;

namespace Domain.Users.Events;

public sealed record UserRegistered(Guid UserId): IDomainEvent;