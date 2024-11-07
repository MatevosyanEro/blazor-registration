using Microsoft.EntityFrameworkCore;
using Reg.Data;
using Reg.Models;
using System.Net;
namespace Reg.Services
{
	public class UserService : IUserService
	{
		private readonly AppDbContext _db;
		public UserService(AppDbContext db)
		{
			_db = db;
		}
		public async Task<int> AddUserAsync(User user)
		{
			try
			{
				_db.Users.Add(user);
				await _db.SaveChangesAsync();
				return (int)HttpStatusCode.OK;
			}
			catch(Exception ex) {
				Console.WriteLine(ex.Message);

				return (int)HttpStatusCode.BadRequest;
			}

		}

		public async Task<bool> ValidateUserAsync(string email, string password)
		{
			try
			{
				var user = await _db.Users.FirstOrDefaultAsync(u => u.Email == email);
				if (user != null && user.Password == password)
				{
					return true;
				}
				return false;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
		
		public async Task<bool> IsEmailExistingAsync(string email)
		{
			var existing_email = await _db.Users.FirstOrDefaultAsync(u => u.Email == email);
			if (existing_email != null) {
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
