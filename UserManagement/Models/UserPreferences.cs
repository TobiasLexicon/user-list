using System;
namespace UserManagement.Models
{
    public class UserPreferences
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Language Language { get; set; }

        public UserPreferences()
        {

        }

        public UserPreferences(int id, User user, Language language)
        {
            Id = id;
            User = user;
            Language = language;
        }
    }
}

