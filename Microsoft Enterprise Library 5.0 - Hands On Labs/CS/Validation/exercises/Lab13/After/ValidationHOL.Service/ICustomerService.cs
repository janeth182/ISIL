using System.ServiceModel;
using Microsoft.Practices.EnterpriseLibrary.Validation.Integration.WCF;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using ValidationHOL.BusinessLogic;

namespace ValidationHOL.Service
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        [FaultContract(typeof(ValidationFault))]
        string ProcessCustomer(
            Customer customer,
            [StringLengthValidator(1, 100,
                MessageTemplate = "The notes must be 1 to 100 characters long.")]
            string notes);
    }
}
