using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SpecFlowDemo.Pages;

namespace SpecFlowDemo.StepDefinitions
{
    [Binding]
    public class AdminDashboardStepDefinitions
    {

        private readonly Adminmenu AdminPage;

        public AdminDashboardStepDefinitions (IWebDriver driver)
        {
            this.AdminPage = new Adminmenu(driver);
        }

        [Given(@"I launch  application with URL")]
        public void GivenILaunchApplicationWithURL(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            AdminPage.OpenWebDriver((string)data.URL);
        }
        [Then(@"click on SignIn")]
        public void ThenClickOnSignIn()
        {
            AdminPage.ClickOnSignIn();
        }
        [Then(@"I enter  Username and Password")]
        public void ThenIEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            AdminPage.EnterCredentials((string)data.UserName, (string)data.Password);
        }
        [When(@"I click Log in button")]
        public void WhenIClickLogInButton()
        {
            AdminPage.ClickLogIn();
        }
        [Then(@"I click Admin Dashboard menu")]
        public void ThenIClickAdminDashboardMenu()
        {
            AdminPage.ClickAdminDashboard();
        }
        [Then(@"Navigate for admin Menu Page")]
        public void ThenNavigateForAdminMenuPage()
        {
            AdminPage.NavigateAdminmenu();
        }


    }
}
