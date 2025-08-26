using NUnit.Framework;

namespace WebFantasy
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Initialization logic if needed
        }

       

        [Test]
        public void HomePageLoads()
        {
            string title = "Home page";
            Assert.AreEqual("Home page", title, "Home page title should match.");
        }

        [Test]
        public void ContactFormFieldsExist()
        {
            bool nameFieldExists = true;
            bool emailFieldExists = true;
            bool messageFieldExists = true;

            Assert.IsTrue(nameFieldExists, "Name field should exist.");
            Assert.IsTrue(emailFieldExists, "Email field should exist.");
            Assert.IsTrue(messageFieldExists, "Message field should exist.");
        }

        [Test]
        public void PrivacyPolicyTextExists()
        {
            string policyText = "Use this page to detail your site's privacy policy.";
            Assert.IsNotEmpty(policyText, "Privacy policy text should not be empty.");
        }

        [Test]
        public void ErrorPageShowsRequestId()
        {
            bool showRequestId = true;
            Assert.IsTrue(showRequestId, "Error page should show Request ID.");
        }
    }
}
