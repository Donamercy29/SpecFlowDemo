using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SpecFlowDemo.Pages;

namespace SpecFlowDemo.StepDefinitions
{
    [Binding]
    public class Feature1StepDefinitions
    {

        private readonly MemberPage memberPage;

        public Feature1StepDefinitions(IWebDriver driver)
        {
            this.memberPage = new MemberPage(driver);
        }


        [Given(@"I launch the application with URL")]
        public void GivenILaunchTheApplicationWithURL(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            memberPage.OpenWebDriver((string)data.URL);
        }
        [Then(@"click on Sign In")]
        public void ThenClickOnSignIn()
        {
            memberPage.ClickSignIn();
              Thread.Sleep(1000);
        }

        [Then(@"I enter the Username and Password")]
        public void ThenIEnterTheUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            memberPage.EnterValidCredentials((string)data.UserName, (string)data.Password);    
            Thread.Sleep(1000);          
            
        }

        [When(@"I click signin button")]
        public void WhenIClickSigninButton()
        {
            memberPage.ClickTheLogin();
            Thread.Sleep(1000);
        }
        [Then(@"Navigate for All Menu Pages")]
        public void ThenNavigateForAllMenuPages()
        {
            memberPage.NavigateAllMenu();
        }


        [Then(@"I click signout button")]
        public void ThenIClickSignoutButton()
        {
            Thread.Sleep(5000); 

        }



    }
}
