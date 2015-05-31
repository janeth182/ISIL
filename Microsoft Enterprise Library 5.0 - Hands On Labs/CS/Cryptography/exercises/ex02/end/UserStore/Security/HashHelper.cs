using System;
using System.Collections.Generic;
using System.Text;
// TODO: Use Cryptography
using Microsoft.Practices.EnterpriseLibrary.Security.Cryptography;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;

namespace UserStore.Security
{
    class HashHelper
    {


        private HashHelper() { }

        // TODO: Hash provider name must match app.config
        private const string hashProvider = "PasswordHasher";

        public static string CreateHash(string plainText)
        {
            string hash = null;

            // TODO: Hash the plain text
            //hash = plainText;
						CryptographyManager crypto = EnterpriseLibraryContainer.Current.GetInstance<CryptographyManager>();
						hash = crypto.CreateHash(hashProvider, plainText);

            return hash;
        }

        public static bool CompareHash(string plainText, string hashedText)
        {
            bool compare = false;

            // TODO: Compare plain text with hash
            //compare = (plainText == hashedText);
						CryptographyManager crypto = EnterpriseLibraryContainer.Current.GetInstance<CryptographyManager>();
						compare = crypto.CompareHash(hashProvider, plainText, hashedText);

            return compare;
        }
    }
}
