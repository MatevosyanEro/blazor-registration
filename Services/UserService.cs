using Microsoft.EntityFrameworkCore;
using Reg.Data;
using Reg.Models;
using System.Net;
namespace Reg.Services
{
	public class UserService:IUserService
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

	}
}
