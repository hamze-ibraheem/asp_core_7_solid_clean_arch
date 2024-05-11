namespace HR.LeaveManagement.Domain
{

    public class LeaveAllocation : BaseEntity
    {
        public int NymberOfDays { get; set; }

        public LeaveType? LeaveType { get; set; }

        public int LeaveTypeId { get; set; }

        public int Period { get; set; }
    }
}