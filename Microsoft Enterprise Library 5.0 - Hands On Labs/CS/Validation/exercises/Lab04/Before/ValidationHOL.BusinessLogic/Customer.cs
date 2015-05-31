using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace ValidationHOL.BusinessLogic
{
    public class Customer
    {
        [StringLengthValidator(1, 25)]
        public string FirstName { get; set; }
        [StringLengthValidator(1, 25)]
        public string LastName { get; set; }
        [RegexValidator(@"^\d\d\d-\d\d-\d\d\d\d$")]
        public string SSN { get; set; }
        [ObjectValidator]
        public Address Address { get; set; }
    }
}
