using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;

namespace UserStore.Configuration
{
    public class UserSettings : ConfigurationSection
    {
        public const string SectionName = "userStore";

        public static UserSettings GetUserSettings(IConfigurationSource configurationSource)
        {
            ConfigurationSection section = configurationSource.GetSection(UserSettings.SectionName);
            return section as UserSettings;
        }

        [ConfigurationProperty("users")]
        public UserElementCollection Users
        {
            get { return (UserElementCollection)this["users"]; }
            set { this["users"] = value; }
        }

        public UserSettings Clone()
        {
            UserSettings data = new UserSettings();
            data.Users = new UserElementCollection();

            foreach (UserElement elem in this.Users)
            {
                data.Users.Add(elem.Clone());
            }

            return data;
        }
    }
}
