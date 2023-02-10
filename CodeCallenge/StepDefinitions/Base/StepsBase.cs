using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeCallenge.Pages;

namespace CodeCallenge.StepDefinitions.Base
{
    [Binding]
    internal class StepsBase
    {
        UserManagementPage _userManagementPage;

        public StepsBase(UserManagementPage userManagementPage)
        {
            _userManagementPage = userManagementPage;
        }

        [Given(@"I login Scenario With User '([^']*)' and Password '([^']*)'")]
        public void GivenILoginScenarioWithUserAndPassword(string user, string password)
        {

            _userManagementPage.Login(user, password);
        }

    }
}
