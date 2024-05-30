using Domain.Abstraction;

namespace Domain.Users.Events;

public sealed record UserRoleChanged(Guid UserId) : IDomainEvent;