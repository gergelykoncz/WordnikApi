namespace WordnikApi.Models
{
    public class ApiTokenStatus
    {
        public long ExpiresInMilliseconds { get; set; }
        public bool IsValid { get; set; }
        public long RemainingCalls { get; set; }
        public long ResetsInMilliseconds { get; set; }
        public long TotalRequests { get; set; }
        public string Token { get; set; }
    }
}