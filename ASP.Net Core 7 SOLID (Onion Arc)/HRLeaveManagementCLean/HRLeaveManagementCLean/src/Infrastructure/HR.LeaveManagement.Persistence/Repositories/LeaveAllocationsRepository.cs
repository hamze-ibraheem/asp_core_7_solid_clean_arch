using HR.LeaveManagement.Domain;
using HR.LeaveManagementApplication.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;

namespace HR.LeaveManagement.Persistence.Repositories;

public class LeaveAllocationsRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
{

    public LeaveAllocationsRepository(HrDatabaseContext context) : base(context)
    {

    }

    public async Task AddAllocations(List<LeaveAllocation> allocations)
    {
        await _context.AddRangeAsync(allocations);
    }

    public async Task<bool> AllocationExists(string userId, int leaveTypeId, int period)
    {
        return await _context.LeaveAllocations.AnyAsync(q => q.EmployeeId == userId && q.LeaveTypeId == leaveTypeId && q.Period == period);
    }

    public async Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails()
    {
        var leaveAllocations = await _context.LeaveAllocations.Include(q => q.LeaveType).ToListAsync();
        return leaveAllocations;
    }

    public async Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails(string userId)
    {
        var leaveAllocations = await _context.LeaveAllocations
            .Where(q => q.EmployeeId == userId)
            .Include(q => q.LeaveType).ToListAsync();
        return leaveAllocations;
    }

    public async Task<LeaveAllocation> GetLeaveAllocationWithDetails(int id)
    {
        var leaveAllocations = await _context.LeaveAllocations.Include(q => q.Id == id).FirstOrDefaultAsync();
        return leaveAllocations;
    }

    public async Task<LeaveAllocation> GetUserAllocations(string userId, int leaveTypeId)
    {
        var leaveAllocations = await _context.LeaveAllocations.FirstOrDefaultAsync(q => q.EmployeeId == userId && q.LeaveTypeId == leaveTypeId);
        return leaveAllocations;
    }
}
