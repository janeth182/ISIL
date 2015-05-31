using System;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using ValidationHOL.BusinessLogic;

namespace ValidationHOL
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Validator<Customer> customerValidator;

        private void MainForm_Load(object sender, EventArgs e)
        {
            ValidatorFactory valFactory =
                EnterpriseLibraryContainer.Current.GetInstance<ValidatorFactory>();
            customerValidator = valFactory.CreateValidator<Customer>();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                SSN = ssnTextBox.Text,
                Address = new Address
                {
                    StreetAddress = streetAddressTextBox.Text,
                    City = cityTextBox.Text,
                    State = stateComboBox.Text,
                    ZipCode = zipCodeTextBox.Text
                }
            };

            ValidationResults results = customerValidator.Validate(customer);
            if (!results.IsValid)
            {
                StringBuilder builder = new StringBuilder();
                builder.AppendLine("Customer is not valid:");
                foreach (ValidationResult result in results)
                {
                    builder.AppendLine(
                        string.Format(
                            CultureInfo.CurrentCulture,
                            "{0}: {1}",
                            result.Key,
                            result.Message));
                }
                MessageBox.Show(
                    this,
                    builder.ToString(),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(
                this,
                "Processing customer '" + customer.FirstName + "'",
                "Working",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
