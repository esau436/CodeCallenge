using Gherkin;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCallenge.Pages.Base
{
    public class BasePage
    {
        private By loginButtonLink = By.Id("login2");
        private By userName = By.Id("loginusername");
        private By passwordtext = By.Id("loginpassword");
        private By LoginButton = By.XPath("//div[@id='logInModal']//div[@class='modal-dialog']//button[@class='btn btn-primary']");
        private By closeButtonLoginModal = By.XPath("//div[@id='logInModal']//div[@class='modal-dialog']//button[@class='btn btn-secondary']");


        WebDriver driver = Hooks.Hooks.driver;
        int timeoutInSeconds = Hooks.Hooks.timeWaitElement;
        public void Login(string user, string password)
        {
            WaitElementTobeClickcableOrVisuable(loginButtonLink).Click();
            driver.SwitchTo().ActiveElement();
            Pause(3);
            WaitElementTobeClickcableOrVisuable(userName).SendKeys(user);
            WaitElementTobeClickcableOrVisuable(passwordtext).SendKeys(password);
            Pause();
            WaitElementTobeClickcableOrVisuable(LoginButton).Click();

        }
        public void CloseLoginModal()
        {
            WaitElementTobeClickcableOrVisuable(closeButtonLoginModal).Click();
        }
        private IWebElement WaitElementTobeClickcableOrVisuable(By element)
        {

            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(element));
            }
            return driver.FindElement(element);
        }

        public string ReturnWebElementText(By element)
        {
            Pause();
           var elementText= WaitElementTobeClickcableOrVisuable(element);
           return elementText.Text;
        }

        public string GetMessageFromAlertPage()
        {
           
            IAlert alert = driver.SwitchTo().Alert();

            //Store the alert in a variable for reuse
            string text = alert.Text;

            //Press the Cancel button
            alert.Dismiss();

            return text;
        }

        public void ClickElement(By element)
        {
            Pause();
            WaitElementTobeClickcableOrVisuable(element).Click();   
        }
        public IWebElement GetWebElement(By element)
        {
            return WaitElementTobeClickcableOrVisuable(element);
        }
        public void SendTextElement(By element,string text)
        {
            Pause();
            WaitElementTobeClickcableOrVisuable(element).SendKeys(text);
        }

        public void Pause(int secods =2)
        {
            Thread.Sleep(secods * 1000);
        }
    }
}
