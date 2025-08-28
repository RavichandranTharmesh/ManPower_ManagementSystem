using System.ComponentModel.DataAnnotations;

namespace WorkManagementSystem.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username or Email is required.")]
        public string username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string password { get; set; }

        public bool RememberMe { get; set; }
    }
}
