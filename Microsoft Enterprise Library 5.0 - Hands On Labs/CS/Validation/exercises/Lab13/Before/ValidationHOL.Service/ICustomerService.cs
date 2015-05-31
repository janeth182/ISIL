using System.ServiceModel;
using ValidationHOL.BusinessLogic;

namespace ValidationHOL.Service
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        string ProcessCustomer(Customer customer, string notes);
    }
}
