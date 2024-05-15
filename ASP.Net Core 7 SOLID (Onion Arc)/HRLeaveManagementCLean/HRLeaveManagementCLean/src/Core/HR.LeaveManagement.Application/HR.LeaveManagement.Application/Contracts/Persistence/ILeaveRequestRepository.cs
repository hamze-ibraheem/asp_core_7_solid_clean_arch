using HR.LeaveManagement.Domain;

namespace HR.LeaveManagementApplication.Contracts.Persistence
{

    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestWithDetails(int id);

        Task<List<LeaveRequest>> GetLeaveRequestsWithDetails();

        Task<List<LeaveRequest>> GetLeaveRequestsWithDetails(string userId);
    }
}