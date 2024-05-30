using Domain.Abstraction;

namespace Domain.Users.Events;

public sealed record FreelancerProfileUpdated(Guid FreelancerId) : IDomainEvent;