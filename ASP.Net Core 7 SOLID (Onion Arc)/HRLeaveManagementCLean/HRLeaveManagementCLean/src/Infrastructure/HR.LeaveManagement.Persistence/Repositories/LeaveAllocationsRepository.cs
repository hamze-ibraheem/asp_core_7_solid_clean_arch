using HR.LeaveManagement.Domain;
using HR.LeaveManagementApplication.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;

namespace HR.LeaveManagement.Persistence.Repositories;

public class LeaveAllocationsRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
{

    public LeaveAllocationsRepository(HrDatabaseContext context) : base(context)
    {

    }
}
