using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using Microsoft.Practices.EnterpriseLibrary.Validation;

namespace ValidationHOL.BusinessLogic
{
    public class Address
    {
        [StringLengthValidator(1, 50)]
        public string StreetAddress { get; set; }
        [ValidatorComposition(CompositionType.And)]
        [StringLengthValidator(1, 30)]
        [ContainsCharactersValidator("sea", ContainsCharacters.All)]
        public string City { get; set; }
        [StringLengthValidator(2, 2)]
        public string State { get; set; }
        [RegexValidator(@"^\d{5}$")]
        public string ZipCode { get; set; }
    }
}
