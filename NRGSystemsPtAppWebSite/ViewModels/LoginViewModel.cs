using System.ComponentModel.DataAnnotations;

namespace NRGSystemsPtAppWebSite.ViewModels
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide a User Name")]
        public string? UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide a Password")]
        public string? Password { get; set; }
    }
}
