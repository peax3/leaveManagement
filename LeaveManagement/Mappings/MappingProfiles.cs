using AutoMapper;
using LeaveManagement.Data;
using LeaveManagement.Models;

namespace LeaveManagement.Mappings
{
    public class MappingProfiles : Profile
    {

        public MappingProfiles()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
            CreateMap<LeaveType, CreateLeaveTypeVM>().ReverseMap();
            CreateMap<LeaveType, DetailsLeaveTypeVM>().ReverseMap();

            CreateMap<LeaveHistory, LeaveHistoryVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();
        }
    }
}
