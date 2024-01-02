using System.ComponentModel.DataAnnotations;

namespace DreamDirectum.Core.Models.RequestModels
{
    public record PaginationParameters
    {
        [Range(1, 100, ErrorMessage = "Limit must be greater than 0 and less or equal to 100.")]
        public int Limit { get; set; } = 10;

        [Range(0, int.MaxValue, ErrorMessage = "Offset must be greater than or equal to 0.")]
        public int Offset { get; set; } = 0;
    }
}
