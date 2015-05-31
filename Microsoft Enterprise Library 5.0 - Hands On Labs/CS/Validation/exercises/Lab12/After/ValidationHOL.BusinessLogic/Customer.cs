using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using ValidationHOL.BusinessLogic.Properties;
using ValidationHOL.CustomValidators;

namespace ValidationHOL.BusinessLogic
{
    public class Customer
    {
        [StringLengthValidator(1, 25,
            MessageTemplateResourceType = typeof(Resources),
            MessageTemplateResourceName = "FirstNameMessage")]
        public string FirstName { get; set; }
        [StringLengthValidator(1, 25,
            MessageTemplateResourceType = typeof(Resources),
            MessageTemplateResourceName = "LastNameMessage")]
        public string LastName { get; set; }
        [SSNValidator]
        public string SSN { get; set; }
        [ObjectValidator]
        public Address Address { get; set; }
    }
}
