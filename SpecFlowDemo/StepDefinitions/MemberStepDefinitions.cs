using OpenQA.Selenium;
using SpecFlowDemo.Pages;
using System;
using System.Security.Policy;
using System.Xml.Linq;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.StepDefinitions
{
    [Binding]
    public class MemberStepDefinitions
    { 
        private readonly MemberPage memberPage;

        public MemberStepDefinitions(IWebDriver driver)
        {
            this.memberPage = new MemberPage(driver);
        }


        [Given(@"Launch the valid url:")]
        public void GivenLaunchTheValidUrl(Table table)
        {
            memberPage.OpenWebDriver("https://churchar.cmallianceuu.org ");
        }
        [When(@"i click the Sign In Button")]
        public void WhenIClickTheSignInButton()
        {
            memberPage.ClickSignIn();
        }

             [When(@"I enter the valid credentials:")]
        public void WhenIEnterTheValidCredentials(string UserName,string Password)
        {
            memberPage.EnterValidCredentials(UserName, Password);
        }

        [When(@"I click the Login")]
        public void WhenIClickTheLogin()
        {
            memberPage.ClickTheLogin();
        }

     


    }
}
