namespace HR.LeaveManagement.Domain
{

    public class LeaveRequest : BaseEntity
    {


        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public LeaveType? LeaveType { get; set; }

        public int LeaverTypeId { get; set; }

        public DateTime DateRequested { get; set; }

        public String? RequestComments { get; set; }

        public bool? Approved { get; set; }

        public bool Cancelled { get; set; }

        public string RequestingEmployeeId { get; set; } = string.Empty;



    }
}