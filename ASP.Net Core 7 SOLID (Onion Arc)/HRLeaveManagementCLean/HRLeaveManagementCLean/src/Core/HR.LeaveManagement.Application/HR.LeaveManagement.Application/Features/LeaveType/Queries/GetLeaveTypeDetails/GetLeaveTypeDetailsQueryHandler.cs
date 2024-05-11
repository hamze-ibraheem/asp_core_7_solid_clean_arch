using AutoMapper;
using HR.LeaveManagement.Application.Exceptions;
using HR.LeaveManagementApplication.Contracts.Persistence;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails
{
    public class GetLeaveTypeDetailsQueryHendler : IRequestHandler<GetLeaveTypeDetailsQuery, LeaveTypeDetailsDto>
    {
        IMapper _mapper;
        ILeaveTypeRepository _leaveTypeRepository;

        GetLeaveTypeDetailsQueryHendler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            this._mapper = mapper;
            this._leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<LeaveTypeDetailsDto> Handle(GetLeaveTypeDetailsQuery request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveTypeRepository.GetByIdAsync(request.Id);

            //verify that record exist.
            if (leaveType == null)
                throw new NotFoundException(nameof(LeaveType), request.Id);

            var data = _mapper.Map<LeaveTypeDetailsDto>(leaveType);

            return data;
        }
    }
}