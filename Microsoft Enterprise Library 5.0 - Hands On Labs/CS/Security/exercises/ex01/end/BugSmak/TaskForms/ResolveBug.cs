using System.Security;
using System.Security.Permissions;
using BugSmak.Security;

namespace BugSmak.TaskForms
{
    public partial class ResolveBug : BaseForm
    {
        private ResolveBug()
        {
            InitializeComponent();
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "Developer")]
        [PrincipalPermission(SecurityAction.Demand, Role = "Manager")]
        public static ResolveBug Create()
        {
            // TODO: Check Authorization

            return new ResolveBug();
        }
    }
}

