using System.ComponentModel.DataAnnotations;

namespace IdentityChangeName.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
