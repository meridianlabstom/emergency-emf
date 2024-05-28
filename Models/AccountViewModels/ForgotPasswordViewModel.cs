using System.ComponentModel.DataAnnotations;

namespace edxl_cap_v1_2.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
