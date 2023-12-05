namespace DreamDirectum.Core.Models.Dtos
{
    public record EmployeeDto
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string DepartmentName { get; set; }
        public MutationDto[] Mutations { get; set; }
    }
}
