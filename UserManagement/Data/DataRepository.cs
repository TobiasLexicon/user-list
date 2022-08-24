using System;
using UserManagement.Models;

namespace UserManagement.Data
{
    public class DataRepository
    {
        public static List<User> users = new()
        {
            new User(1, "Klaus", "45ferry" ),
            new User(2, "Gert", "we2222"),
            new User(3, "Maud", "oppy")
        };

        public static List<UserPreferences> usersPreferences = new()
        {
            new UserPreferences(1, users[0], Language.Swedish),
            new UserPreferences(2, users[1], Language.English),
            new UserPreferences(3, users[2], Language.Swedish)
        };




        static User user = new ()
        {
            Id = 1,
            Name = "Tristan",
            Password = "123Gut"
        };

        static UserPreferences userPreferences = new()
        {
            Id = 1,
            Language = Models.Language.Swedish
        };

        public static User GetUser()
        {
            return user;
        }

        public static UserPreferences GetUserPreferences()
        {
            return userPreferences;
        }

        public DataRepository()
        {
        }
    }
}

