using CodeCallenge.Pages.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeCallenge.Pages.Home
{
    public class HomePage : BasePage
    {
        public By carousel = By.Id("carouselExampleIndicators");
        public By productStoreLink = By.Id("nava");

        public void validateNavaLink(string linkName) {

          var textWebElement =  ReturnWebElementText(By.XPath($"//div[@id='navbarExample']//a[contains(text(),'{linkName}')]"));
          Assert.IsTrue(textWebElement.Contains(linkName));
        
        }
        

    }
}
