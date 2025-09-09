namespace POE_Part_1.Models // Defines the models namespace
{
    public class ErrorViewModel // Model for error information
    {
        public string? RequestId { get; set; } // Property to store the request ID

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId); // Computed property to check if RequestId has value
    }
}