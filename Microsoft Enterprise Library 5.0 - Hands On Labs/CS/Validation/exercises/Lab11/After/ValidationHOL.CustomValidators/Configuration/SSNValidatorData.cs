using System;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Design;
using ValidationHOL.CustomValidators.Properties;

namespace ValidationHOL.CustomValidators.Configuration
{
    [ResourceDescription(typeof(Resources), "SSNValidatorDescription")]
    [ResourceDisplayName(typeof(Resources), "SSNValidatorName")]
    public class SSNValidatorData : ValueValidatorData
    {
        public SSNValidatorData()
        {
        }

        public SSNValidatorData(string name)
            : base(name, typeof(SSNValidator))
        {
        }

        [ConfigurationProperty("ignoreHyphens")]
        [ResourceDescription(typeof(Resources), "IgnoreHyphensDescription")]
        [ResourceDisplayName(typeof(Resources), "IgnoreHyphensName")]
        public bool IgnoreHyphens
        {
            get
            {
                return (bool)this["ignoreHyphens"];
            }
            set
            {
                this["ignoreHyphens"] = value;
            }
        }

        protected override Validator DoCreateValidator(Type targetType)
        {
            return new SSNValidator(this.Tag, this.IgnoreHyphens);
        }
    }
}
