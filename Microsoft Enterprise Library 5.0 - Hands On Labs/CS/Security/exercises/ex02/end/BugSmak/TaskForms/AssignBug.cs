using System.Security;
using System.Security.Permissions;
using BugSmak.Security;

namespace BugSmak.TaskForms
{
    public partial class AssignBug : BaseForm
    {
        private AssignBug()
        {
            InitializeComponent();
        }

        //[PrincipalPermission(SecurityAction.Demand, Role = "Manager")]
        public static AssignBug Create()
        {
            // TODO: Check Authorization
            if (!SecurityHelper.Authorized(AuthRule.Assign))
            {
                throw new SecurityException();
            }

            return new AssignBug();
        }
    }
}
