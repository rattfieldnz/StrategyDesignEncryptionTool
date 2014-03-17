using EncryptionToolPractical;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EncryptionToolUnitTests
{
    
    
    /// <summary>
    ///This is a test class for PlainTextTest and is intended
    ///to contain all PlainTextTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PlainTextTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for PlainText Constructor
        ///</summary>
        /*[TestMethod()]
        public void PlainTextConstructorTest()
        {
            IEncryptor target = new PlainText();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }*/

        /// <summary>
        ///A test for encrypt
        ///</summary>
        [TestMethod()]
        public void encryptTestPlainTextLowerCaseString()
        {
            IEncryptor target = new PlainText(); 
            string textToEncrypt = "alphabravocharlie";
            string expected = "alphabravocharlie";
            string actual;
            actual = target.encrypt(textToEncrypt);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void encryptTestPlainTextUpperCaseString()
        {
            IEncryptor target = new PlainText();
            string textToEncrypt = "ALPHABRAVOCHARLIE";
            string expected = "ALPHABRAVOCHARLIE";
            string actual;
            actual = target.encrypt(textToEncrypt);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void encryptTestPlainTextIntegers()
        {
            IEncryptor target = new PlainText();
            string textToEncrypt = "123456789";
            string expected = "123456789";
            string actual;
            actual = target.encrypt(textToEncrypt);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void encryptTestPlainTextIntegersUpperCase()
        {
            IEncryptor target = new PlainText();
            string textToEncrypt = "1A2B3C4D5E6F7G8H9I";
            string expected = "1A2B3C4D5E6F7G8H9I";
            string actual;
            actual = target.encrypt(textToEncrypt);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void encryptTestPlainTextIntegersLowerCase()
        {
            IEncryptor target = new PlainText();
            string textToEncrypt = "1a2b3c4e5f6g7h8i";
            string expected = "1a2b3c4e5f6g7h8i";
            string actual;
            actual = target.encrypt(textToEncrypt);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void encryptTestPlainTextIntegersLowerUpperCase()
        {
            IEncryptor target = new PlainText();
            string textToEncrypt = "1aZ2bY3cX4eW5fV6gU7hT8iS";
            string expected = "1aZ2bY3cX4eW5fV6gU7hT8iS";
            string actual;
            actual = target.encrypt(textToEncrypt);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void encryptTestPlainTextSpecialCharacters()
        {
            IEncryptor target = new PlainText();
            string textToEncrypt = "!@#$%^&*()_+";
            string expected = "!@#$%^&*()_+";
            string actual;
            actual = target.encrypt(textToEncrypt);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void encryptTestPlainTextSpecialCharactersLowerCase()
        {
            IEncryptor target = new PlainText();
            string textToEncrypt = "a!b@c#d$e%f^g&h*i(j)k_l+m";
            string expected = "a!b@c#d$e%f^g&h*i(j)k_l+m";
            string actual;
            actual = target.encrypt(textToEncrypt);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void encryptTestPlainTextSpecialCharactersUpperCase()
        {
            IEncryptor target = new PlainText();
            string textToEncrypt = "A!B@C#D$E%F^G&H*I(J)K_L+M";
            string expected = "A!B@C#D$E%F^G&H*I(J)K_L+M";
            string actual;
            actual = target.encrypt(textToEncrypt);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void encryptTestPlainTextSpecialCharactersLowerUpperCase()
        {
            IEncryptor target = new PlainText();
            string textToEncrypt = "Az!By@Cx#Dw$Ev%Fu^Gt&Hs*Ir(Jq)Kp_Lo+Mn";
            string expected = "Az!By@Cx#Dw$Ev%Fu^Gt&Hs*Ir(Jq)Kp_Lo+Mn";
            string actual;
            actual = target.encrypt(textToEncrypt);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void encryptTestPlainTextSpecialCharactersLowerUpperCaseIntegers()
        {
            IEncryptor target = new PlainText();
            string textToEncrypt = "1Az!2By@3Cx#4Dw$5Ev%6Fu^7Gt&8Hs*9Ir(0Jq)1Kp_2Lo+3Mn";
            string expected = "1Az!2By@3Cx#4Dw$5Ev%6Fu^7Gt&8Hs*9Ir(0Jq)1Kp_2Lo+3Mn";
            string actual;
            actual = target.encrypt(textToEncrypt);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void encryptTestPlainTextSpecialCharactersIntegers()
        {
            IEncryptor target = new PlainText();
            string textToEncrypt = "0!9@8#7$6%5^4&3*2(1)";
            string expected = "0!9@8#7$6%5^4&3*2(1)";
            string actual;
            actual = target.encrypt(textToEncrypt);
            Assert.AreEqual(expected, actual);
        }
    }
}
