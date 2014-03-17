using EncryptionToolPractical;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EncryptionToolUnitTests
{
    
    
    /// <summary>
    ///This is a test class for Rot13Test and is intended
    ///to contain all Rot13Test Unit Tests
    ///</summary>
    [TestClass()]
    public class Rot13Test
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
        ///A test for Rot13 Constructor
        ///</summary>
        /*[TestMethod()]
        public void Rot13ConstructorTest()
        {
            Rot13 target = new Rot13();;
            Assert.Inconclusive("TODO: Implement code to verify target");
        }*/

        /// <summary>
        ///A test for encrypt
        ///</summary>
        [TestMethod()]
        public void encryptTestPlainTextLowerCaseString()
        {
            IEncryptor target = new Rot13();
            string textToEncrypt = "alphabravocharlie";
            string expected = "nycunoenibpuneyvr";
            string actual;
            actual = target.encrypt(textToEncrypt);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void encryptTestPlainTextLowerCaseStringWithWhiteSpace()
        {
            IEncryptor target = new Rot13();
            string textToEncrypt = "a l p h a b r a v o c h a r l i e";
            string expected = "n y c u n o e n i b p u n e y v r";
            string actual;
            actual = target.encrypt(textToEncrypt);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void encryptTestPlainTextUpperCaseString()
        {
            IEncryptor target = new Rot13();
            string textToEncrypt = "ALPHABRAVOCHARLIE";
            string expected = "NYCUNOENIBPUNEYVR";
            string actual;
            actual = target.encrypt(textToEncrypt);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void encryptTestPlainTextIntegers()
        {
            IEncryptor target = new Rot13();
            string textToEncrypt = "123456789";
            string expected = "123456789";
            string actual;
            actual = target.encrypt(textToEncrypt);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void encryptTestPlainTextIntegersUpperCase()
        {
            IEncryptor target = new Rot13();
            string textToEncrypt = "1A2B3C4D5E6F7G8H9I";
            string expected = "1N2O3P4Q5R6S7T8U9V";
            string actual;
            actual = target.encrypt(textToEncrypt);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void encryptTestPlainTextIntegersLowerCase()
        {
            IEncryptor target = new Rot13();
            string textToEncrypt = "1a2b3c4e5f6g7h8i";
            string expected = "1n2o3p4r5s6t7u8v";
            string actual;
            actual = target.encrypt(textToEncrypt);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void encryptTestPlainTextIntegersLowerUpperCase()
        {
            IEncryptor target = new Rot13();
            string textToEncrypt = "1aZ2bY3cX4eW5fV6gU7hT8iS";
            string expected = "1nM2oL3pK4rJ5sI6tH7uG8vF";
            string actual;
            actual = target.encrypt(textToEncrypt);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void encryptTestPlainTextSpecialCharacters()
        {
            IEncryptor target = new Rot13();
            string textToEncrypt = "!@#$%^&*()_+";
            string expected = "!@#$%^&*()_+";
            string actual;
            actual = target.encrypt(textToEncrypt);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void encryptTestPlainTextSpecialCharactersLowerCase()
        {
            IEncryptor target = new Rot13();
            string textToEncrypt = "a!b@c#d$e%f^g&h*i(j)k_l+m";
            string expected = "n!o@p#q$r%s^t&u*v(w)x_y+z";
            string actual;
            actual = target.encrypt(textToEncrypt);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void encryptTestPlainTextSpecialCharactersUpperCase()
        {
            IEncryptor target = new Rot13();
            string textToEncrypt = "A!B@C#D$E%F^G&H*I(J)K_L+M";
            string expected = "N!O@P#Q$R%S^T&U*V(W)X_Y+Z";
            string actual;
            actual = target.encrypt(textToEncrypt);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void encryptTestPlainTextSpecialCharactersLowerUpperCase()
        {
            IEncryptor target = new Rot13();
            string textToEncrypt = "Az!By@Cx#Dw$Ev%Fu^Gt&Hs*Ir(Jq)Kp_Lo+Mn";
            string expected = "Nm!Ol@Pk#Qj$Ri%Sh^Tg&Uf*Ve(Wd)Xc_Yb+Za";
            string actual;
            actual = target.encrypt(textToEncrypt);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void encryptTestPlainTextSpecialCharactersLowerUpperCaseIntegers()
        {
            IEncryptor target = new Rot13();
            string textToEncrypt = "1Az!2By@3Cx#4Dw$5Ev%6Fu^7Gt&8Hs*9Ir(0Jq)1Kp_2Lo+3Mn";
            string expected = "1Nm!2Ol@3Pk#4Qj$5Ri%6Sh^7Tg&8Uf*9Ve(0Wd)1Xc_2Yb+3Za";
            string actual;
            actual = target.encrypt(textToEncrypt);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void encryptTestPlainTextSpecialCharactersIntegers()
        {
            IEncryptor target = new Rot13();
            string textToEncrypt = "0!9@8#7$6%5^4&3*2(1)";
            string expected = "0!9@8#7$6%5^4&3*2(1)";
            string actual;
            actual = target.encrypt(textToEncrypt);
            Assert.AreEqual(expected, actual);
        }
    }
}
