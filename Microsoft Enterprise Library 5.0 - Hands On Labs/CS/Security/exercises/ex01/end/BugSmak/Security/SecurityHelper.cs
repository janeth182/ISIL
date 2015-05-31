using System;
using System.Collections.Generic;
using System.Security;
using System.Security.Principal;
using System.Threading;
// TODO: Use Web Security
using System.Web.Security;
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
            authenticated = Membership.ValidateUser(username, password);

            // TODO: Get Roles
            if (!authenticated)
                return false;

            IIdentity identity;
            identity = new GenericIdentity(username, Membership.Provider.Name);

            string[] roles = Roles.GetRolesForUser(identity.Name);
            IPrincipal principal = new GenericPrincipal(identity, roles);

            // Place user's principal on the thread
            Thread.CurrentPrincipal = principal;

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
