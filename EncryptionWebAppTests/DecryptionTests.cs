using Microsoft.VisualStudio.TestTools.UnitTesting;
using EncryptionWebApp.Models;

namespace EncryptionWebAppTests
{
    /// <summary>
    /// Tests the different methods of decryption.
    /// </summary>
    [TestClass]
    public class DecryptionTests
    {
        [TestMethod]
        public void Test_CaesarDecryptMethod()
        {
            // arrange
            string testLine = "���? ABC!";
            string expectedResult = "xyz? ���!";
            string result;

            // act
            result = CaesarCipherMethod.Decrypt(testLine);

            // assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}