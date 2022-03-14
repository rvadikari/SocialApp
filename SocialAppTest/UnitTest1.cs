using Microsoft.VisualStudio.TestTools.UnitTesting;
using SocialApp.Models;

namespace SocialAppTest
{
    [TestClass]
    public class UnitTest1
    {
        public void Setup()
        {

        }
        [TestMethod]
        public void TestMethod1()
        {
            const string actual= "Hello world from social app";
            Test t = new Test();
            string expected = t.HelloWorld();
            Assert.AreEqual(expected, actual);
        }
    }
}
