using System.ComponentModel.DataAnnotations;

namespace IdentityChangeName.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
