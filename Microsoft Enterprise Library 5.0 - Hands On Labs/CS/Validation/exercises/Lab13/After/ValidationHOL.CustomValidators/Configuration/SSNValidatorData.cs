using System;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Configuration;

namespace ValidationHOL.CustomValidators.Configuration
{
    public class SSNValidatorData : ValueValidatorData
    {
        public SSNValidatorData()
        {
        }

        public SSNValidatorData(string name)
            : base(name, typeof(SSNValidator))
        {
        }

        [ConfigurationProperty("ignoreHypens")]
        public bool IgnoreHypens
        {
            get
            {
                return (bool)this["ignoreHypens"];
            }
            set
            {
                this["ignoreHypens"] = value;
            }
        }

        protected override Validator DoCreateValidator(Type targetType)
        {
            return new SSNValidator(this.Tag, this.IgnoreHypens);
        }
    }
}
