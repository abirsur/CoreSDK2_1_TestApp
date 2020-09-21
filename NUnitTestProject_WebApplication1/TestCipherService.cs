using Microsoft.AspNetCore.DataProtection;
using NUnit.Framework;
using WebApplication1.Common;

namespace NUnitTestProject_WebApplication1
{
    public class TestCipherService
    {

        IDataProtectionProvider dataProtectionProvider = DataProtectionProvider.Create("WebApplication1");

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestEncryptionDecryptionService()
        {
            string dataToTest = "Hello World!";
            string encData = new CipherService(dataProtectionProvider).Encrypt(dataToTest);
            string decData = new CipherService(dataProtectionProvider).Decrypt(encData);
            Assert.AreEqual(decData, dataToTest);              
        }       
    }
}
