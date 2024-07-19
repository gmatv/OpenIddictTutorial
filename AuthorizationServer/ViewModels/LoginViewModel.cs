using System.ComponentModel.DataAnnotations;

namespace AuthorizationServer.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public required string Username { get; init; }
        
        [Required]
        public required string Password { get; init; }
        
        public string? ReturnUrl { get; init; }
    }
}
