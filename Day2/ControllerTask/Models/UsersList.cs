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
            
        public static async void AddUserAsync()
        {
            await Task.Run((Action)AddUser);
        }

        public static List<User> GetAll()
        {
            Thread.Sleep(2000);
            return Users;
        }

        private static void AddUser()
        {
            if (Users == null)
                Users = new List<User>();
            Thread.Sleep(2000);
            Users.Add(new User()
            {
                Name = "User",
                SecondName = "Userov"
            });
        }
    }
}