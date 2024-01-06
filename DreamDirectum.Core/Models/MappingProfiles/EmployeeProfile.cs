using AutoMapper;
using DreamDirectum.Core.Models.Dtos;
using Sungero.IntegrationService.Models.Generated.NewDreamSolution;

namespace DreamDirectum.Core.Models.MappingProfiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<IEmployeeDto, EmployeeDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.Phone))
                .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department != null ? src.Department.Name : null ))
                .ForMember(dest => dest.JobTitle, opt => opt.MapFrom(src => src.JobTitle != null ? src.JobTitle.Name : null ))
                .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => (src.Person != null) ? (DateTime?)src.Person.DateOfBirth.Value.UtcDateTime : null ));
        }
    }
}
