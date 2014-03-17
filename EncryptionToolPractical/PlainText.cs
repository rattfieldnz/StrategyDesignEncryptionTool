using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncryptionToolPractical
{
    /// <summary>
    /// This class is responsible for 'encrypting' 
    /// text using no encryption, i.e. the encrypt 
    /// method in this class just returns the 
    /// original text.
    /// </summary>
    class PlainText: IEncryptor
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public PlainText()
        {
        }

        /// <summary>
        /// This method 'encrypts' a given string.
        /// (not really).
        /// </summary>
        /// <param name="textToEncrypt">The string to 'encrypt'.</param>
        /// <returns>The 'encrypted' string.</returns>
        public string encrypt(string textToEncrypt)
        {
            return textToEncrypt;
        }
    }
}
