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
            Assert.Equals(nullCase, auth.SignIn("",""));
            Assert.Equals(failCase, auth.SignIn("Invalid", "Invalid@123"));
            Assert.Equals(passCase, auth.SignIn("naveen", "naveen@123"));
        }
    }
}
