using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowDemo.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.FW.Pages.SpecFlowDemo
{


    public class LoginPage : BasePageObject
    {
        public LoginPage(IWebDriver webDriver) : base(webDriver) { }



        public void LoadData(string username, string passowrd)
        {
            _webDriver.FindElement(By.XPath("//*[@type='text']")).SendKeys(username);
            _webDriver.FindElement(By.XPath("//*[@id='password']")).SendKeys(passowrd);
        }
        public void ClickLoginButton()
        {
            _webDriver.FindElement(By.XPath("//*[@type='submit']")).Click();
        }
        public void CheckDashboard()
        {
            string Mytitle = _webDriver.Title;
            Assert.AreEqual("ReligiO", Mytitle);
        }



    }


}
