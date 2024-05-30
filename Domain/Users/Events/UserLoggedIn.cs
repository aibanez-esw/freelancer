using Domain.Abstraction;

namespace Domain.Users.Events;

public sealed record UserLoggedIn(Guid UserId) : IDomainEvent;