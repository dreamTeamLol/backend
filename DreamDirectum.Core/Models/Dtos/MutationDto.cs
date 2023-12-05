namespace DreamDirectum.Core.Models.Dtos
{
    public record MutationDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset? AppliedDate { get; set; }
        public string Note { get; set; }
    }
}
