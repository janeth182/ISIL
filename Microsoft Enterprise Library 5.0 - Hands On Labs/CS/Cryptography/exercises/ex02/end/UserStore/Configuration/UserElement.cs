using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace UserStore.Configuration
{
    public class UserElement : ConfigurationElement
    {
        public UserElement()
        {
        }

        public UserElement(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }

        [ConfigurationProperty("name", IsRequired = true, IsKey = true)]
        public string Name
        {
            get { return (string)this["name"]; }
            set { this["name"] = value; }
        }

        [ConfigurationProperty("password", IsRequired = true)]
        public string Password
        {
            get { return (string)this["password"]; }
            set { this["password"] = value; }
        }

        public UserElement Clone()
        {
            return new UserElement(this.Name, this.Password);
        }
    }
}
