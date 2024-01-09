using System.ComponentModel.DataAnnotations;

namespace DreamDirectum.Core.Models.RequestModels
{
    public record DateOffsetParameters
    {
        [Range(1, 31, ErrorMessage = "BirthdayRangeLeftBorder must be greater than 0 and less or equal to 31.")]
        public int BirthdayRangeLeftBorder { get; set; } = 31;

        [Range(1, 31, ErrorMessage = "BirthdayRangeRightBorder must be greater than 0 and less or equal to 31.")]
        public int BirthdayRangeRightBorder { get; set; } = 31;
    }
}
