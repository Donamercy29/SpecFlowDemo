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
        MemberPage memberPage = new MemberPage();
       
        [Given(@"Launch the valid url:")]
        public void GivenLaunchTheValidUrl(Table table)
        {
            memberPage.GivenLaunchThe("https://churchar.cmallianceuu.org ");
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

        [Then(@"I click the Admin Dashboard")]
        public void ClickTheAdminDashboard()
        {
            memberPage.ClickTheAdminDashboard();
        }
        [Then(@"I click the Section")]
        public void ThenIClickTheSection()
        {
            memberPage.clickonSections();
        }

        [Given(@"i click the Add button")]
        public void GivenIClickTheAddButton()
        {
            memberPage.clickonAdd();
        }

        [When(@"i Type the details '([^']*)' and '([^']*)'")]
        public void WhenITypeTheDetailsAnd(string ssectionname, string sdescription)
        {
            memberPage.TypetheDetails(ssectionname, sdescription);
        }

        [Then(@"I click the Save button")]
        public void ThenIClickTheSaveButton()
        {
            memberPage.clickonSave();
        }



    }
}
