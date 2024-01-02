namespace DreamDirectum.Core.Models.Dtos
{
    public record SubstitutionDto
    {
        public EmployeeDto User { get; set; }
        public EmployeeDto Substitue { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Comment { get; set; }
    }
}
