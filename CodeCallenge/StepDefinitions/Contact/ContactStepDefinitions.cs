using CodeCallenge.Pages.Contact;
using System;
using TechTalk.SpecFlow;

namespace CodeCallenge.StepDefinitions.Contact
{
    [Binding]
    public class ContactStepDefinitions
    {
        ContactPage contactPage;

        public ContactStepDefinitions(ContactPage contactPage)
        {
            this.contactPage = contactPage;
        }

        [When(@"I click on Contact Button")]
        public void WhenIClickOnContactButton()
        {
            contactPage.ClickElement(contactPage.contackButtonLink);
        }
        [Then(@"I Fill the as Contact Email '([^']*)'")]
        public void ThenIFillTheAsContactEmail(string email)
        {
            contactPage.SendTextElement(contactPage.contactEmail, email);
        }
        [Then(@"I Fill the as Contact Name '([^']*)'")]
        public void ThenIFillTheAsContactName(string contactName)
        {
            contactPage.SendTextElement(contactPage.contactName, contactName);
        }
        [Then(@"I Fill the as Message '([^']*)'")]
        public void ThenIFillTheAsMessage(string messsage)
        {
            contactPage.SendTextElement(contactPage.message, messsage);
        }
        [When(@"I click on Send Message Button")]
        public void WhenIClickOnSendMessageButton()
        {
            contactPage.ClickElement(contactPage.sendMessageModalButton);
        }



    }
}
