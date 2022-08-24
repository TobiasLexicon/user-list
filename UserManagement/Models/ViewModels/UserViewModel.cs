using System;
namespace UserManagement.Models.ViewModels
{
    public class UserViewModel
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public Language Language { get; set; }

        public UserViewModel() { }

        public UserViewModel(string name, string password, Language language)
        {
            Name = name;
            Password = password;
            Language = language;
        }
    }
}

