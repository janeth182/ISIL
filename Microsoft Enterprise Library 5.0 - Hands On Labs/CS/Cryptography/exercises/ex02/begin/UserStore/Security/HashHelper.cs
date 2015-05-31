using System;
using System.Collections.Generic;
using System.Text;
// TODO: Use Cryptography

namespace UserStore.Security
{
    class HashHelper
    {
        private HashHelper() { }

        // TODO: Hash provider name must match app.config

        public static string CreateHash(string plainText)
        {
            string hash = null;

            // TODO: Hash the plain text
            hash = plainText;

            return hash;
        }

        public static bool CompareHash(string plainText, string hashedText)
        {
            bool compare = false;

            // TODO: Compare plain text with hash
            compare = (plainText == hashedText);

            return compare;
        }
    }
}
