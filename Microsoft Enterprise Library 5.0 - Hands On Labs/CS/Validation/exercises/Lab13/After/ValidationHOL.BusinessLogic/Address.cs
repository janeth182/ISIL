using System.Runtime.Serialization;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace ValidationHOL.BusinessLogic
{
    [DataContract]
    public class Address
    {
        [StringLengthValidator(1, 50)]
        [DataMember]
        public string StreetAddress { get; set; }
        [StringLengthValidator(1, 30)]
        [DataMember]
        public string City { get; set; }
        [StringLengthValidator(2, 2)]
        [DataMember]
        public string State { get; set; }
        [RegexValidator(@"^\d{5}$")]
        [DataMember]
        public string ZipCode { get; set; }
    }
}
