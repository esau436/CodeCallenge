using CodeCallenge.Pages;
using CodeCallenge.StepDefinitions.Base;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace CodeCallenge.StepDefinitions
{
    [Binding]
    public class UserManagementStepDefinitions
    {
        UserManagementPage usrManagement;
        public UserManagementStepDefinitions(UserManagementPage usrManagement) 
        {
            this.usrManagement = usrManagement;
        }

        [When(@"I Verify Message Error Contains '([^']*)'")]
        public void WhenIVerifyMessageErrorContains(string message)
        {
            var alertMessage = usrManagement.GetMessageFromAlertPage();
            Assert.AreEqual(alertMessage, message);
        }
        [Then(@"I click on Close Modal")]
        public void ThenIClickOnCloseModal()
        {
            usrManagement.CloseLoginModal();
        }
        [Then(@"I Verify if Welcome Message is showing on the page as '([^']*)' user")]
        public void ThenIVerifyIfWelcomeMessageIsShowingOnThePageAsUser(string admin)
        {
            Assert.AreEqual(usrManagement.ReturnWebElementText(usrManagement.nameOfUser), "Welcome "+admin);
        }






    }
}
