using System;
using System.Collections.Generic;
using System.Security;
using System.Security.Principal;
using System.Threading;
// TODO: Use Web Security

// TODO: Use EntLib Security

namespace BugSmak.Security
{
    class SecurityHelper
    {
        private SecurityHelper() 
        { }

        public static bool Authenticate(string username, string password)
        {
            bool authenticated = false;

            // TODO: Authenticate Credentials

            // TODO: Get Roles

            return authenticated;
        }

        public static bool Authorized(string rule)
        {
            bool authorized = false;

            // TODO: Check rule-base authorization

            return authorized;
        }
    }
}
