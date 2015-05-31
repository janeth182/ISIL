using System.ComponentModel.DataAnnotations;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace ValidationHOL.BusinessLogic
{
    public class Customer
    {
        [StringLengthValidator(5, MessageTemplate="Name must be less than 5 characters.")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Country is required")]
        [DomainValidator("ARG", "ITA", "USA", MessageTemplate = "Invalid country")]
        public string Country { get; set; }
    }
}