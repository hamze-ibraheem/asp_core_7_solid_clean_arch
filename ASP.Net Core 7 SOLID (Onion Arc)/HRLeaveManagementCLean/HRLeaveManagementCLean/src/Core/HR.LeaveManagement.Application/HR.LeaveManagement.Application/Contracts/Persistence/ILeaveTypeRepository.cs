using HR.LeaveManagement.Domain;

namespace HR.LeaveManagementApplication.Contracts.Persistence
{

    public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
    {
        Task<bool> IsLeaveTypeUnique(string Name);
    }
}