using System;
using System.Collections.Generic;
using System.Text;

namespace UserStore
{
    public class UserManager
    {
        private static UserManagerImplementation implementation = new UserManagerImplementation();

        private UserManager()
        {
        }

        public static bool ChangePassword(string name, string oldPassword, string newPassword)
        {
            return implementation.ChangePassword(name, oldPassword, newPassword);
        }

        public static void CreateUser(string name, string password)
        {
            implementation.CreateUser(name, password);
        }

        public static void DeleteUser(string name)
        {
            implementation.DeleteUser(name);
        }

        public static string[] GetNames()
        {
            return implementation.GetNames();
        }

        public static void Refresh()
        {
            implementation.Load();
        }

        public static void Save()
        {
            implementation.Save();
        }

        public static bool ValidateUser(string name, string password)
        {
            return implementation.ValidateUser(name, password);
        }

        public static bool ResetPassword(string name, string newPassword)
        {
            return implementation.ResetPassword(name, newPassword);
        }
    }
}
