using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public sealed class PlanAJourneyStepDefinitions
    {
        private IWebDriver driver;

        [Given(@"Open the Tfl website")]
        public void GivenOpenTheTflWebsite()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://tfl.gov.uk/";
        }

        [Given(@"Accept Cookie settings")]
        public void GivenAcceptCookieSettings()
        {
            driver.FindElement(By.XPath("//button[@id ='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll']")).Click();
        }

        [When(@"Select the Plan a Journey tab")]
        public void WhenSelectThePlanAJourneyTab()
        {
            driver.FindElement(By.XPath("//a[@href ='/plan-a-journey/']")).Click();
        }

        [Then(@"Provide From and To details and check the result")]
        public void ThenProvideFromAndToDetailsAndCheckTheResult()
        {
            IWebElement From = driver.FindElement(By.XPath("//input[@id ='InputFrom']"));
            From.SendKeys("Liverpool Street");

            IWebElement To = driver.FindElement(By.XPath("//input[@name='InputTo']"));
            To.SendKeys("Heathrow Airport Terminal 4");

            driver.FindElement(By.XPath("//input[@id='plan-journey-button']")).Click();
        }

        [Then(@"Provide invalid From and To details and check the result")]
        public void ThenProvideInvalidFromAndToDetailsAndCheckTheResult()
        {
            IWebElement From = driver.FindElement(By.XPath("//input[@id ='InputFrom']"));
            From.SendKeys("xyz");

            IWebElement To = driver.FindElement(By.XPath("//input[@name='InputTo']"));
            To.SendKeys("Heathrow Airport Terminal 4");
        }

        [Then(@"Provide no details in the  From and To fields and check the result")]
        public void ThenProvideNoDetailsInTheFromAndToFieldsAndCheckTheResult()
        {
            IWebElement error = driver.FindElement(By.XPath("//span[@id = 'InputFrom-error']"));
            if (error.Displayed == true)
            {
                Console.WriteLine(error.Text);
                Console.WriteLine("TestCase Passed");

            }

            else

            {

                Console.WriteLine("Failed");
            }
        }

    }

}