using ValidationHOL.BusinessLogic;

namespace ValidationHOL.Service
{
    public class CustomerService : ICustomerService
    {
        public string ProcessCustomer(Customer customer, string notes)
        {
            return "Processed customer " + customer.FirstName + ". Notes: " + notes;
        }
    }
}
