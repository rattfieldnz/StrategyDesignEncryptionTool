using EncryptionToolPractical;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EncryptionToolUnitTests
{
    
    
    /// <summary>
    ///This is a test class for IEncryptorTest and is intended
    ///to contain all IEncryptorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IEncryptorTest
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


        internal virtual IEncryptor CreateIEncryptor()
        {
            // TODO: Instantiate an appropriate concrete class.
            IEncryptor target = null;
            return target;
        }

        /// <summary>
        ///A test for encrypt
        ///</summary>
       /* [TestMethod()]
        public void encryptTest()
        {
            IEncryptor target = CreateIEncryptor(); // TODO: Initialize to an appropriate value
            string textToEncrypt = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.encrypt(textToEncrypt);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }*/
    }
}
