using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncryptionToolPractical
{
    /// <summary>
    /// This interface is used to create 
    /// objects that use some form of encryption.
    /// </summary>
    interface IEncryptor
    {
        /// <summary>
        /// The default encrypt method.
        /// </summary>
        /// <param name="textToEncrypt">The text to encrypt.</param>
        /// <returns>The encrypted string.</returns>
        string encrypt(string textToEncrypt);
    }
}
