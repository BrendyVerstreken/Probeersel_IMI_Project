using Imi.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Services.Mocking
{
    public class MockUsersService : IUserService
    {
        private static List<User> users = new List<User>
        {
            new User{
                Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                UserName = "Brendy",
                Email="vbrendy@htmail.com",
            }
        };

        public async Task<User> GetUser(Guid id)
        {
            var user = users.FirstOrDefault(e => e.Id == id);
            return await Task.FromResult(user);
        }

        public async Task<User> UpdateUser(User user)
        {
            var oldUser = users.FirstOrDefault(e => e.Id == user.Id);
            users.Remove(oldUser);
            users.Add(user);
            return await Task.FromResult(oldUser);
        }
    }
}
