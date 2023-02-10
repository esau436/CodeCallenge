using CodeCallenge.Pages;
using CodeCallenge.Pages.Home;
using CodeCallenge.StepDefinitions.Base;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace CodeCallenge.StepDefinitions.Home
{
    [Binding]
    public class HomePageStepDefinitions 
    {
        HomePage homePage; 
        public HomePageStepDefinitions(HomePage homePage)
        {
            this.homePage = homePage;
        }
        [When(@"I validate if In Van-bar the '([^']*)' is showing")]
        [Then(@"I validate if In Van-bar the '([^']*)' is showing")]
        public void WhenIValidateIfInVan_BarTheIsShowing(string linkNavarName)
        {
            homePage.validateNavaLink(linkNavarName);
        }
        [Then(@"I Validate If Carousel is Showing On the page")]
        public void ThenIValidateIfCarouselIsShowingOnThePage()
        {
            Assert.True(homePage.GetWebElement(homePage.carousel).Enabled);
        }
        [Given(@"I Click On Home Page Link")]
        public void GivenIClickOnHomePageLink()
        {
            homePage.GetWebElement(homePage.productStoreLink).Click();
        }



    }
}
