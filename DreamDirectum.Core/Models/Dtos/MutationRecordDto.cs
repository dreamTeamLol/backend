namespace DreamDirectum.Core.Models.Dtos
{
    public record MutationRecordDto
    {
        public int Id { get; set; }
        public EmployeeDto Employee { get; set; }
        public string Mutation { get; set; }
        public DateTimeOffset? AppliedDate { get; set; }
        public string Note { get; set; }
    }
}
