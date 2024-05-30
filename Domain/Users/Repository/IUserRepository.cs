using Domain.Users.Entities;

namespace Domain.Users.Repository
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(User user);
        Task<User> GetAsync(Guid uuid);
        Task<IEnumerable<User>> GetAllAsync();
    }
}
