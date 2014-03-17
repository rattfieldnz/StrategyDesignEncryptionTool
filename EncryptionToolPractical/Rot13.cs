using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncryptionToolPractical
{
    /// <summary>
    /// This class is responsible for encrypting 
    /// text using the ROT13 algorithm.
    /// </summary>
    class Rot13: IEncryptor
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Rot13()
        {
        }

        /// <summary>
        /// This method does the ROT13 encryption, 
        /// using s type of simple Caesar-Shift.
        /// </summary>
        /// <param name="textToEncrypt">The string to encrypt.</param>
        /// <returns>The encrypted version of the string parsed in.</returns>
        public string encrypt(string textToEncrypt)
        {
            ///<summary>
            ///Get each character in the string, 
            ///and add them to a char array.
            ///</summary>
            char[] charArray = textToEncrypt.ToCharArray();

            ///<summary>
            ///Iterate over each character in the string
            ///to encrypt.
            for (int i = 0; i < charArray.Length; i++)
            {
                ///<summary>
                ///Get the integer value of the current
                ///character (ASCII value).
                int charNumber = (int)charArray[i];

                ///<summary>
                ///Check to see if the character's ASCII number 
                ///is between the 1st and last characters of the 
                ///alphabet.
                ///</summary>
                
                if (charNumber >= 'a' && charNumber <= 'z')
                {
                    ///<summary>
                    ///FOR LOWER-CASE CHARACTERS:
                    ///If the character's integer value
                    ///is less than the integer value for
                    ///the alphabet's middle character, 
                    ///subtract 13 from the number, or 
                    ///add 13 if otherwise.
                    ///</sumamry>
                    if (charNumber > 'm')
                    {
                        charNumber -= 13;
                    }
                    else
                    {
                        charNumber += 13;
                    }
                }

                else if (charNumber >= 'A' && charNumber <= 'Z')
                {
                    ///<summary>
                    ///FOR UPPER-CASE CHARACTERS:
                    ///If the character's integer value
                    ///is less than the integer value for
                    ///the alphabet's middle character, 
                    ///subtract 13 from the number, or 
                    ///add 13 if otherwise.
                    ///</sumamry>
                    if (charNumber > 'M')
                    {
                        charNumber -= 13;
                    }
                    else
                    {
                        charNumber += 13;
                    }
                }

                ///<summary>
                ///Swap each character in the char array.
                ///</summary>
                charArray[i] = (char)charNumber;
                
            }

            ///<summary>
            ///Return the encrypted result.
            return new string(charArray);

        }
    }
}
