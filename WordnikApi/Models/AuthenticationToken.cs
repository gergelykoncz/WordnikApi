namespace WordnikApi.Models
{
    public class AuthenticationToken
    {
        public string Token { get; set; }
        public long UserId { get; set; }
        public string UserSignature { get; set; }
    }
}
