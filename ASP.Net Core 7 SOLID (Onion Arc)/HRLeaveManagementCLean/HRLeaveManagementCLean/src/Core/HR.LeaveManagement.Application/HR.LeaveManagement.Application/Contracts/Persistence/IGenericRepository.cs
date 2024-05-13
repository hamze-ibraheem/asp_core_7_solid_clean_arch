using HR.LeaveManagement.Domain; 

namespace HR.LeaveManagementApplication.Contracts.Persistence
{

    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<IReadOnlyList<T>> GetAsync();

        Task<T> GetByIdAsync(int Id);

        Task CreateAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);
    }
}