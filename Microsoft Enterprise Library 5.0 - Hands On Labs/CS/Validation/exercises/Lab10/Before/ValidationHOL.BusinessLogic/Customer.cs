using ValidationHOL.CustomValidators;

namespace ValidationHOL.BusinessLogic
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [SSNValidator]
        public string SSN { get; set; }
        public Address Address { get; set; }
    }
}
