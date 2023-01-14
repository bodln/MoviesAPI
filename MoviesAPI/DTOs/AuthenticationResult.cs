namespace MoviesAPI.DTOs
{
    public class AuthenticationResult
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
