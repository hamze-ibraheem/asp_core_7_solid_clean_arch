using HR.LeaveManagement.Domain;
using HR.LeaveManagementApplication.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;

namespace HR.LeaveManagement.Persistence.Repositories;

public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
{

    public LeaveRequestRepository(HrDatabaseContext context) : base(context)
    {

    }


}
