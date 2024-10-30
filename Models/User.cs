using System.ComponentModel.DataAnnotations;

namespace Reg.Models
{
	public class User
	{
		public int Id { get; set; }
		[Required(ErrorMessage = " Name is Required")]
		[StringLength(50, ErrorMessage = "Name will be less than 50 char")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Surname is Required")]
		[StringLength(50, ErrorMessage = "Surname will be less than 50 char")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "Mail is Required")]
		[EmailAddress(ErrorMessage = "invalid email")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Password is Required")]
		[StringLength(100, MinimumLength = 6, ErrorMessage = "Password will be less than 100 more than 6 chars")]
		public string Password { get; set; }
		public DateOnly? Created { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);
		public DateOnly? Updated { get; set; }
		public DateOnly? Deleted { get; set; }
	}
}
