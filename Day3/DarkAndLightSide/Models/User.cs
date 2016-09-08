using System.Collections.Generic;

namespace DarkAndLightSide.Models
{
    public class User
    {
        public string Name {  get; set; }
        public int Age { get; set; }
        public Side Side { get; set; }
    }

    public enum Side
    {
        Light = 1,
        Dark 
    }

    public static class Users
    {
        public static List<User> UsersList { get; set; }

        static Users()
        {
            UsersList = new List<User>();
        }
    }
}