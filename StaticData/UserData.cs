using Website.Models;
using System.Collections.Generic;
namespace Website.StaticData
{
    public class UserData
    {
        public static List<UserModel> People 
        {
            get
            {
                return listOfUsers;
            }
        }

        private static List<UserModel> listOfUsers = new List<UserModel>()
        {
            new UserModel() { UserId = 1, Email = "email@what.creativity", Password = "needsHash", FullName = "Tom Scott", Role = "t" },
            new UserModel() { UserId = 2, Email = "email@example", Password = "defaultsUnhashed", FullName = "Minion", Role = "admin" },
            new UserModel() { UserId = 3, Email = "email@test.default", Password = "mustHash", FullName = "Slave", Role = "dev" },
        };
    }
}