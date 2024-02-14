using AuthLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AuthUnittest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SignInTest()
        {
            Authentication auth =new Authentication();
            string failCase = "Invalid Credientials";
            string nullCase = "Provide Username and password";
            string passCase = "Signin Success";
            Assert.AreEqual(nullCase, auth.SignIn("",""));
            Assert.AreEqual(failCase, auth.SignIn("Invalid", "Invalid@123"));
            Assert.AreEqual(passCase, auth.SignIn("naveen", "naveen@123"));
        }
    }
}
