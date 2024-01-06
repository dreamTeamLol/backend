using System.ComponentModel.DataAnnotations;

namespace DreamDirectum.Core.Models.RequestModels
{
    public record DateOffsetParameters
    {
        [Range(1, 31, ErrorMessage = "DaysBefore must be greater than 0 and less or equal to 31.")]
        public int DaysBefore { get; set; } = 31;

        [Range(1, 31, ErrorMessage = "DaysAfter must be greater than 0 and less or equal to 31.")]
        public int DaysAfter { get; set; } = 31;
    }
}
