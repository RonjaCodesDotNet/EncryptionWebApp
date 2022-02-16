using Microsoft.VisualStudio.TestTools.UnitTesting;
using EncryptionWebApp.Models;

namespace EncryptionWebAppTests
{
    /// <summary>
    /// Tests the different methods of encryption.
    /// </summary>
    [TestClass]
    public class EncryptionTests
    {
        [TestMethod]
        public void Test_CaesarEncryptMethod()
        {
            // arrange
            string testLine = "ÅÄÖ? ABC!";
            string expectedResult = "abc? def!";
            string result;

            // act
            result = CaesarCipherMethod.Encrypt(testLine);

            // assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}