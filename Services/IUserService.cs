using Reg.Models;
namespace Reg.Services
{
	public interface IUserService
	{
		Task<int> AddUserAsync(User user);
		//Task<User> GetUserByIdAsync(int Id);
		//Task<List<User>> GetUsersAsync();
	}
}
