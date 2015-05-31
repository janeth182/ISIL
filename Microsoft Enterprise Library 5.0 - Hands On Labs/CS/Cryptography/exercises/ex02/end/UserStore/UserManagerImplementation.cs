using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using UserStore.Configuration;
using UserStore.Security;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;

namespace UserStore
{
    class UserManagerImplementation
    {
        private IConfigurationSource _source = null;
        private UserSettings _settings = null;
        private string _filePath = null;

        #region Constructor
        public UserManagerImplementation()
        {
            // Get configuration source
            this._source = ConfigurationSourceFactory.Create(UserSettings.SectionName);

            // Load & Clone configuration (so not read-only)
            this.Load();

            // Determine configuration file path
            if (this.Source is SystemConfigurationSource)
            {
                this._filePath = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
            }
            else if (this.Source is FileConfigurationSource)
            {
                ConfigurationSourceSection configurationSourceSection =
                    ConfigurationSourceSection.GetConfigurationSourceSection();

                FileConfigurationSourceElement objectConfiguration
                    = (FileConfigurationSourceElement)configurationSourceSection.Sources.Get(UserSettings.SectionName);

                FileConfigurationSourceElement e = (FileConfigurationSourceElement)objectConfiguration;
                this._filePath = objectConfiguration.FilePath;
            }
        }
        
        #endregion

        #region Private

        private IConfigurationSource Source
        {
            get { return this._source; }
        }

        private UserSettings UserSettings
        {
            get
            {
                if (this._settings == null)
                    this._settings = new UserSettings();

                return this._settings;
            }
        }

        private string FilePath
        {
            get { return this._filePath; }
        }
        
        #endregion

        public bool ChangePassword(string name, string oldPassword, string newPassword)
        {
            if (!this.ValidateUser(name, oldPassword))
                return false;

            UserElement user = this.UserSettings.Users[name];
            user.Password = HashHelper.CreateHash(newPassword);

            return true;
        }

        public void CreateUser(string name, string password)
        {
            string hash = HashHelper.CreateHash(password);
            this.UserSettings.Users.Add(new UserElement(name, hash));
        }

        public void DeleteUser(string name)
        {
            this.UserSettings.Users.Remove(name);
        }

        public string[] GetNames()
        {
            ArrayList list = new ArrayList();

            foreach (UserElement user in this.UserSettings.Users)
            {
                list.Add(user.Name);
            }

            list.Sort();

            string[] names = (string[]) list.ToArray(typeof(string));

            return names;
        }

        public void Load()
        {
            UserSettings settings = UserSettings.GetUserSettings(this.Source);

            if (settings != null)
                this._settings = settings.Clone();
        }

        public void Save()
        {
            UserSettings data = this.UserSettings.Clone();

            if (this.Source is FileConfigurationSource)
            {
                FileConfigurationSource fs = this.Source as FileConfigurationSource;
                fs.Save(UserSettings.SectionName, data);
            }

            if (this.Source is SystemConfigurationSource)
            {
                SystemConfigurationSource fs = this.Source as SystemConfigurationSource;
                fs.Save(UserSettings.SectionName, data);
            }
        }

        public bool ResetPassword(string name, string newPassword)
        {
            UserElement user = this.UserSettings.Users[name];
            if (user == null)
                return false;

            user.Password = HashHelper.CreateHash(newPassword);
            return true;
        }

        public bool ValidateUser(string name, string password)
        {
            UserElement user = this.UserSettings.Users[name];
            if (user == null)
                return false;

            return HashHelper.CompareHash(password, user.Password);
        }
    }
}
