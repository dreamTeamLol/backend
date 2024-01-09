using AutoMapper;
using DreamDirectum.Core.Models.Dtos;
using Sungero.IntegrationService.Models.Generated.CoreEntities;
using Sungero.IntegrationService.Models.Generated.NewDreamSolution;

namespace DreamDirectum.Core.Models.MappingProfiles
{
    public class SubstitutionProfile : Profile
    {
        public SubstitutionProfile()
        {
            CreateMap<ISubstitutionDto, SubstitutionDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Employee, opt => opt.MapFrom(src => new EmployeeDto
                {
                    Id = src.User.Id,
                    FullName = src.User.Name,
                    Phone = ((IEmployeeDto)src.User).Phone,
                    DepartmentName = ((IEmployeeDto)src.User).Department != null ? ((IEmployeeDto)src.User).Department.Name : null,
                    JobTitle = ((IEmployeeDto)src.User).JobTitle != null ? ((IEmployeeDto)src.User).JobTitle.Name : null
                }))
                .ForMember(dest => dest.Substitue, opt => opt.MapFrom(src => new EmployeeDto
                {
                    Id = src.Substitute.Id,
                    FullName = src.Substitute.Name,
                    Phone = ((IEmployeeDto)src.Substitute).Phone,
                    DepartmentName = ((IEmployeeDto)src.Substitute).Department != null ? ((IEmployeeDto)src.Substitute).Department.Name : null,
                    JobTitle = ((IEmployeeDto)src.Substitute).JobTitle != null ? ((IEmployeeDto)src.Substitute).JobTitle.Name : null
                }))
                .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate.Value.UtcDateTime))
                .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate.Value.UtcDateTime))
                .ForMember(dest => dest.Comment, opt => opt.MapFrom(src => src.Comment));
        }
    }
}
