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


    public class MemberPage : BasePageObject
    {
        public MemberPage(IWebDriver webDriver) : base(webDriver) { }
         
        private IWebElement txtUserName => _webDriver.FindElement(By.XPath("//*[@type='text']"));
        private IWebElement txtPassword => _webDriver.FindElement(By.XPath("//*[@id='password']"));
        private IWebElement btnLogin => _webDriver.FindElement(By.XPath("//*[@type='submit']"));
        private IWebElement btnsignin => _webDriver.FindElement(By.XPath("(//*[@class='linkedin'])[2]"));
          

        public void ClickSignIn()
        {
            btnsignin.Click();
        }
        public void EnterValidCredentials(string UserName, string Password)
        {
            txtUserName.SendKeys(UserName);
            txtPassword.SendKeys(Password);
            Thread.Sleep(1000);
        }

        public void ClickTheLogin()
        {
            btnLogin.Click();
        }

        public void NavigateAllMenu()
        {
            _webDriver.FindElement(By.XPath("(//*[@id='v-pills-home-tab'])[1]")).Click();
            Thread.Sleep(1000);
            _webDriver.FindElement(By.XPath("(//*[@id='v-pills-home-tab'])[2]")).Click();
            Thread.Sleep(1000);
            _webDriver.FindElement(By.XPath("(//*[@id='v-pills-home-tab'])[3]")).Click();
            Thread.Sleep(1000);
            _webDriver.FindElement(By.XPath("(//*[@id='v-pills-home-tab'])[4]")).Click();
            Thread.Sleep(1000);
        }
    }


}
