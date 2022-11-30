using OpenQA.Selenium;
using SpecFlowDemo.Pages;
using System;
using System.Security.Policy;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    { 

        private readonly LoginPage loginPage;

        public LoginStepDefinitions(IWebDriver driver)
        {
            this.loginPage = new LoginPage(driver);
        }
        

        [Given(@"Launch the application with valid '([^']*)'")]
        public void GivenLaunchTheApplicationWithValid(string sURL)
        {
            loginPage.OpenWebDriver(sURL);
        }

        [When(@"Enter the '([^']*)' and '([^']*)'")]
        public void WhenEnterTheAnd(string sUserName, string sPassword)
        {
            loginPage.LoadData(sUserName,sPassword);
        }

        [When(@"I click the Login button")]
        public void WhenIClickTheLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then(@"Navigate into the Dashboard")]
        public void ThenNavigateIntoTheDashboard()
        {
            loginPage.CheckDashboard();
        }

         

    }
}
