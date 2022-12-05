using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V105.Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.Pages
{


    public class Adminmenu : BasePageObject
    {
        public Adminmenu(IWebDriver webDriver) : base(webDriver) { }
        private IWebElement btnSignIn => _webDriver.FindElement(By.XPath("(//*[@class='linkedin'])[2]"));
        private IWebElement txtUserName => _webDriver.FindElement(By.XPath("//*[@type='text']"));
        private IWebElement txtPassword => _webDriver.FindElement(By.XPath("//*[@id='password']"));
        private IWebElement btnLogin => _webDriver.FindElement(By.XPath("//*[@type='submit']"));
        private IWebElement btnAdmin => _webDriver.FindElement(By.XPath("(//*[@id='v-pills-home-tab'])[4]"));
        private IWebElement btnChurch => _webDriver.FindElement(By.XPath("(//*[@class='fa fa-list'])"));
        private IWebElement btnQuestions => _webDriver.FindElement(By.XPath("(//*[@class='fa fa-question-circle'])"));
        private IWebElement btnSection => _webDriver.FindElement(By.XPath("(//*[@class='fa fa-plus-square'])"));

        public void ClickOnSignIn()
        {
            btnSignIn.Click();
        }
        public void EnterCredentials(string UserName, string Password)
        {
            txtUserName.SendKeys(UserName);
            txtPassword.SendKeys(Password);
            Thread.Sleep(1000);
        }
        public void ClickLogIn()
        {
            btnLogin.Click();
        }
        public void ClickAdminDashboard()
        {
            btnAdmin.Click();
        }
        public void NavigateAdminmenu()
        {
            btnChurch.Click();
            btnQuestions.Click();
            btnSection.Click();
        }
      
    }


}
