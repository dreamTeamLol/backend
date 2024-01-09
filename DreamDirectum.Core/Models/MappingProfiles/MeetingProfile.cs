using AutoMapper;
using DreamDirectum.Core.Models.Dtos;
using Sungero.IntegrationService.Models.Generated.Meetings;

namespace DreamDirectum.Core.Models.MappingProfiles
{
    public class MeetingProfile : Profile
    {
        public MeetingProfile()
        {
            CreateMap<IMeetingDto, MeetingDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.DisplayName, opt => opt.MapFrom(src => src.DisplayName))
                .ForMember(dest => dest.DateTime, opt => opt.MapFrom(src => src.DateTime.Value.UtcDateTime))
                .ForMember(dest => dest.DurationInHours, opt => opt.MapFrom(src => src.Duration))
                .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.Location))
                .ForMember(dest => dest.Secretary, opt => opt.MapFrom(src => new EmployeeDto
                {
                    Id = src.Secretary.Id,
                    FullName = src.Secretary.Name,
                    /*Phone = src.Secretary.Phone,
                    DepartmentName = src.Secretary.Department != null ? src.Secretary.Department.Name : null,
                    JobTitle = src.Secretary.JobTitle != null ? src.Secretary.JobTitle.Name : null*/
                }))
                .ForMember(dest => dest.President, opt => opt.MapFrom(src => new EmployeeDto
                {
                    Id = src.President.Id,
                    FullName = src.President.Name,
                    /*Phone = src.President.Phone,
                    DepartmentName = src.President.Department != null ? src.President.Department.Name : null,
                    JobTitle = src.President.JobTitle != null ? src.President.JobTitle.Name : null*/
                }))
                .ForMember(dest => dest.Members, opt => opt.MapFrom(src => src.Members.Select(e => new EmployeeDto
                {
                    Id = e.Id,
                    FullName = e.Member.Name,
                }).ToArray()))
                .ForMember(dest => dest.Note, opt => opt.MapFrom(src => src.Note));
        }
    }
}
