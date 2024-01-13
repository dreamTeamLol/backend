namespace DreamDirectum.Core.Models.Dtos
{
    public class ResultWrapperDto
    {
        public int ResultStatus { get; set; }
        public object ResultContent { get; set; }
    }

    public class ErrorResponseDto
    {
        public string ErrorTextForUser { get; set; }
    }
}
