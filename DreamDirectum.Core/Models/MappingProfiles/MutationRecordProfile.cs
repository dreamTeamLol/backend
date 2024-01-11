using AutoMapper;
using DreamDirectum.Core.Models.Dtos;
using Sungero.IntegrationService.Models.Generated.EmployeeMutationsModule;

namespace DreamDirectum.Core.Models.MappingProfiles
{
    public class MutationRecordProfile : Profile
    {
        public MutationRecordProfile()
        {
            CreateMap<IEmployeeMutationsLogDto, MutationRecordDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Employee, opt => opt.MapFrom(src => new EmployeeDto
                {
                    Id = src.Employee.Id,
                    FullName = src.Employee.Name,
                    Phone = src.Employee.Phone,
                    DepartmentName = src.Employee.Department != null ? src.Employee.Department.Name : null,
                    JobTitle = src.Employee.JobTitle != null ? src.Employee.JobTitle.Name : null
                }))
                .ForMember(dest => dest.Mutation, opt => opt.MapFrom(src => src.Mutation))
                .ForMember(dest => dest.AppliedDate, opt => opt.MapFrom(src => src.AppliedDate.Value.DateTime))
                .ForMember(dest => dest.Note, opt => opt.MapFrom(src => src.Note));
        }
    }
}
