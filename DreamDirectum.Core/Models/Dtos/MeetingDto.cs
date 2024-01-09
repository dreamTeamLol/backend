namespace DreamDirectum.Core.Models.Dtos
{
    public record MeetingDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public DateTime DateTime { get; set; }
        public int DurationInHours { get; set; }
        public string Location { get; set; }
        public EmployeeDto Secretary { get; set; }
        public EmployeeDto President { get; set; }
        public EmployeeDto[] Members { get; set; }
        public string Note { get; set; }
    }
}
