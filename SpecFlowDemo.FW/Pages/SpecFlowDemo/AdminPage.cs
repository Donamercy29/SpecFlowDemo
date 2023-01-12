using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowDemo.Pages;
//using OpenQA.Selenium.DevTools.V105.Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using static SpecFlowDemo.FW.SpecFlowDemoVariable;

namespace SpecFlowDemo.FW.Pages.SpecFlowDemo
{


    public class Adminmenu : BasePageObject
    {
        public Adminmenu(IWebDriver webDriver) : base(webDriver) { } 
       
        public void ClickOnSignIn()
        {
            FindElementByXPath(XPath_Login.btnSignIn);
        }
        public void EnterCredentials(string UserName, string Password)
        {

            FindElementByXPath(XPath_Login.UserName, UserName);
            FindElementByXPath(XPath_Login.Password, Password);
             
            Thread.Sleep(1000);
        }
        public void ClickLogIn()
        {
            FindElementByXPath(XPath_Login.SignButton); 
        }
        public void ClickAdminDashboard()
        {
            FindElementByXPath(XPath_Menus.btnAdmin); 
        }
        public void NavigateAdminmenu()
        {
            FindElementByXPath(XPath_Menus.btnChurch);
            FindElementByXPath(XPath_Menus.btnQuestions);
            FindElementByXPath(XPath_Menus.btnSection); 
        }

    }


}
