using Domain.Abstraction;

namespace Domain.Users.Events;

public sealed record ContactInformationRemoved(Guid FreelancerId) : IDomainEvent;