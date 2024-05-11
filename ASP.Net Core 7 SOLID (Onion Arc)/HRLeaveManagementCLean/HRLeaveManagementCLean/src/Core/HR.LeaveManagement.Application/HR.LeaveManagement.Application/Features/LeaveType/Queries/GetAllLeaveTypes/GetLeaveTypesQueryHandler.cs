using AutoMapper;
using HR.LeaveManagementApplication.Contracts.Persistence;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes
{

    public class GetLeaveTypesQueryHandler : IRequestHandler<GetLeaveTypesQuery, List<LeaveTypeDto>>
    {
        IMapper _mapper;
        ILeaveTypeRepository _leaveTypeRepository;

        public GetLeaveTypesQueryHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            this._mapper = mapper;
            this._leaveTypeRepository = leaveTypeRepository;
        }
        public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypesQuery request, CancellationToken cancellationToken)
        {
            // Query the database.
            var leaveTypes = await _leaveTypeRepository.GetAsync();

            // convert data objects to Dto objects
            var data = _mapper.Map<List<LeaveTypeDto>>(leaveTypes);

            // return list of DTO objects.
            return data;
        }
    }
}