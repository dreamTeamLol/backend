namespace DreamDirectum.Core.Models.Dtos
{
    public record MutationRecordDto
    {
        public EmployeeDto Employee { get; set; }
        public MutationDto Mutation { get; set; }
    }
}
