using Domain.Abstraction;

namespace Domain.Users.Events;

public sealed record ContactInformationAdded(Guid FreelancerId) : IDomainEvent;