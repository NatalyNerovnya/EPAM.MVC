using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace ControllerTask.Models
{
    public class UsersList
    {
        public static List<User> Users { get; set; }

        public static void AddUser()
        {
            Thread.Sleep(2000);
            Users.Add(new User()
            {
                Name = "User",
                SecondName = "Userov"
            });
        }

    
        public async Task AddUserAsync(User user)
        {
            await Task.Delay(2000);
            AddUser();
        }

        public static List<User> GetAll()
        {
            Thread.Sleep(2000);
            return Users;
        }
    }
}