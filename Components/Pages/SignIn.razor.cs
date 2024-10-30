

using System.ComponentModel.DataAnnotations;

namespace Reg.Components.Pages
{
    public class SignIn
    {
		[Required(ErrorMessage = "Mail is Required")]
		[EmailAddress(ErrorMessage = "invalid email")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Password is Required")]
		[StringLength(100, MinimumLength = 6, ErrorMessage = "Password will be less than 100 more than 6 chars")]
		public string Password { get; set; }
    }
}
