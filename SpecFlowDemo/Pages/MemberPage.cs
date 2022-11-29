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

    
    public class MemberPage
    {
        
        ChromeDriver driver = new ChromeDriver();
       
        public MemberPage()
        {
        }

        public void GivenLaunchThe(string URL)
        {
            driver.Navigate().GoToUrl(URL);
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
        }
       
        public void ClickSignIn()
        {
            driver.FindElement(By.XPath("(//*[@class='linkedin'])[2]")).Click();
        }
        public void EnterValidCredentials(string UserName, string Password)
        {
            driver.FindElement(By.XPath("//*[@type='text']")).SendKeys(UserName);
            driver.FindElement(By.XPath("//*[@id='password']")).SendKeys(Password);
            Thread.Sleep(1000);
        }
    
        public void ClickTheLogin()
        {
            driver.FindElement(By.XPath("//*[@type='submit']")).Click();
        }
    
        public void ClickTheAdminDashboard()
        {
            driver.FindElement(By.XPath("(//*[@id='v-pills-home-tab'])[4]")).Click();
        }
        public void clickonSections()
        {
            driver.FindElement(By.XPath("//*[@class='fa fa-plus-square']")).Click();
        }

        public void clickonAdd()
        {
            driver.FindElement(By.XPath("//*[@id='add-main-section']")).Click();
        }

        internal void TypetheDetails(string sectionname, string description)
        {
            driver.FindElement(By.XPath("//*[@id='main-section-name']")).SendKeys(sectionname);
            driver.FindElement(By.XPath("//*[@id='main-section-description']")).SendKeys(description);
        }

        internal void clickonSave()
        {
            driver.FindElement(By.XPath("//*[@id='add-main-section-btn']")).Click();
        }

       

    
    }


}
