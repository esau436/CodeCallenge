using CodeCallenge.Pages.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCallenge.Pages.Contact
{
    public class ContactPage: BasePage
    {
      public By contackButtonLink = By.XPath("//div[@id='navbarExample']//a[contains(text(),'Contact')]");
        public By contactEmail = By.Id("recipient-email");
        public By contactName = By.Id("recipient-name");
        public By message = By.Id("message-text");
        public By sendMessageModalButton = By.XPath("//div[@id='exampleModal']//div[@class='modal-dialog']//button[@class='btn btn-primary']");

    }
}
