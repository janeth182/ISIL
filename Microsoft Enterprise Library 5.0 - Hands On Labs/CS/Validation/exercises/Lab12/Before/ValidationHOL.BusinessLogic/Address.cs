using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace ValidationHOL.BusinessLogic
{
    public class Address
    {
        [StringLengthValidator(1, 50)]
        public string StreetAddress { get; set; }
        [StringLengthValidator(1, 30)]
        public string City { get; set; }
        [StringLengthValidator(2, 2)]
        public string State { get; set; }
        [RegexValidator(@"^\d{5}$")]
        public string ZipCode { get; set; }
    }
}
