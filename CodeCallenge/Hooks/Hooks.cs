using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using CodeCallenge.Pages.Entities;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace CodeCallenge.Hooks
{
    [Binding]
    public class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        public static  WebDriver? driver;
        public static int timeWaitElement;

        string jsonFileRoute = @"../../../specflow.json";

        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
            string json = File.ReadAllText(jsonFileRoute);
            Properties configurationProperties = JsonConvert.DeserializeObject<Properties>(json);

            switch (configurationProperties.browser)
            {
                case "Chrome":
                    driver =  new ChromeDriver();
                    break;

                case "Edge":
                    driver = new EdgeDriver();
                    break;

                case "Mozilla":
                    driver = new FirefoxDriver();
                    break;

                default:
                    driver = new ChromeDriver();
                    break;
            }

            driver.Url = configurationProperties.url;
            driver.Manage().Window.Maximize();
            timeWaitElement = (int)configurationProperties.timeWaitElement;

        }
        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();  
        }

    }
}