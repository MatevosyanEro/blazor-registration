using Reg.Models;
namespace Reg.Services
{
	public interface IUserService
	{
		Task<int> AddUserAsync(User user);
		Task<bool> ValidateUserAsync(string email,string password);
		Task<bool> IsEmailExistingAsync(string email);
		//Task<User> GetUserByIdAsync(int Id);
		//Task<List<User>> GetUsersAsync();
	}
}
