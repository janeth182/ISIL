using System;
using System.Configuration;

namespace EmployeeBrowser
{
    public class ConnectionManager
    {
        static public bool IsOnline
        {
            get { return true; }
        }

        static public string StatusText
        {
            get { return IsOnline ? "ONLINE" : "OFFLINE"; }
        }
    }
}