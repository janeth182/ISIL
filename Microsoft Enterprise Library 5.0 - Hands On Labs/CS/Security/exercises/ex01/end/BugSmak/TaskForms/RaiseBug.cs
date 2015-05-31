using System.Security;
using System.Security.Permissions;
using BugSmak.Security;

namespace BugSmak.TaskForms
{
    public partial class RaiseBug : BaseForm    
    {
        private RaiseBug()
        {
            InitializeComponent();
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "Employee")]
        [PrincipalPermission(SecurityAction.Demand, Role = "Developer")]
        [PrincipalPermission(SecurityAction.Demand, Role = "Manager")]
        public static RaiseBug Create()
        {
            // TODO: Check Authorization

            return new RaiseBug();
        }
    }
}

