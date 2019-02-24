using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCIMClientLibrary;

namespace UnitTestIIQ_SCIM_API
{
    [TestClass]
    public class IIQClientTest
    {
        private IIQClient client;
        [TestMethod]
        public void Login()
        {
            client = new IIQClient("spadmin", "admin");
            var loginStatus = client.Login();
            Console.WriteLine(loginStatus);
        }

        [TestMethod]
        public void GetUsers()
        {
            client = new IIQClient("spadmin", "admin");
            client.GetUsers("Users");
        }
    }
}
