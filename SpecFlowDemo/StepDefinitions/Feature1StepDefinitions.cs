using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowDemo.StepDefinitions
{
    [Binding]
    public class Feature1StepDefinitions
    {
        ChromeDriver driver = new ChromeDriver();


        private IWebElement txtUserName => driver.FindElement(By.XPath("//*[@type='text']"));
        private IWebElement txtPassword => driver.FindElement(By.XPath("//*[@id='password']"));
        private IWebElement btnLogin => driver.FindElement(By.XPath("//*[@type='submit']"));
        private IWebElement btnsignin => driver.FindElement(By.XPath("(//*[@class='linkedin'])[2]"));



        [Given(@"I launch the application with URL")]
        public void GivenILaunchTheApplicationWithURL(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            driver.Navigate().GoToUrl((string)data.URL);
            driver.Manage().Window.Maximize();
        }
        [Then(@"click on Sign In")]
        public void ThenClickOnSignIn()
        {
            btnsignin.Click();
            Thread.Sleep(1000);
        }

        [Then(@"I enter the Username and Password")]
        public void ThenIEnterTheUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            txtUserName.SendKeys((string)data.UserName);
            Thread.Sleep(1000);
            txtPassword.SendKeys((string)data.Password);
            Thread.Sleep(1000);
        }

        [When(@"I click signin button")]
        public void WhenIClickSigninButton()
        {
            btnLogin.Click();
            Thread.Sleep(1000);
        }

        [Then(@"I click signout button")]
        public void ThenIClickSignoutButton()
        {
            Thread.Sleep(5000);

            driver.Dispose();
        }



    }
}
