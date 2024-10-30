
using System.ComponentModel.DataAnnotations;


public class UserSignUp
{ 
    [Required(ErrorMessage = " Name is Required")]
    [StringLength(50, ErrorMessage = "Name will be less than 50 char")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Surname is Required")]
    [StringLength(50, ErrorMessage = "Surname will be less than 50 char")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Mail is Required")]
    [EmailAddress(ErrorMessage = "invalid email")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password is Required")]
    [StringLength(100, MinimumLength = 6, ErrorMessage = "Password will be less than 100 more than 6 chars")]
    public string Password { get; set; }

    [Required(ErrorMessage = "invalid confirm password")]
    [Compare("Password", ErrorMessage = "passwords doesn't confirm")]
    public string ConfirmPassword { get; set; }
}