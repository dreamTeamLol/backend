using System.ComponentModel.DataAnnotations;

namespace DreamDirectum.Core.Models.RequestModels
{
    public record DateOffsetParameters
    {
        [Range(1, 15, ErrorMessage = "DaysBefore must be greater than 0 and less or equal to 15.")]
        public int DaysBefore { get; set; } = 15;

        [Range(1, 15, ErrorMessage = "DaysAfter must be greater than 0 and less or equal to 15.")]
        public int DaysAfter { get; set; } = 15;
    }
}
