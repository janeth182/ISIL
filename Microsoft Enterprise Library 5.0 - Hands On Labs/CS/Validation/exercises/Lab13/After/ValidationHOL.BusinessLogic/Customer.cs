using System.Runtime.Serialization;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using ValidationHOL.BusinessLogic.Properties;
using ValidationHOL.CustomValidators;

namespace ValidationHOL.BusinessLogic
{
    [DataContract]
    public class Customer
    {
        [StringLengthValidator(1, 25,
            MessageTemplateResourceType = typeof(Resources),
            MessageTemplateResourceName = "FirstNameMessage")]
        [DataMember]
        public string FirstName { get; set; }
        [StringLengthValidator(1, 25,
            MessageTemplateResourceType = typeof(Resources),
            MessageTemplateResourceName = "LastNameMessage")]
        [DataMember]
        public string LastName { get; set; }
        [SSNValidator]
        [DataMember]
        public string SSN { get; set; }
        [ObjectValidator]
        [DataMember]
        public Address Address { get; set; }
    }
}
