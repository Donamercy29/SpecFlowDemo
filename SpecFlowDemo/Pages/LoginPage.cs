using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.Pages
{

    
    public class LoginPage
    {
        
        ChromeDriver driver = new ChromeDriver();
        public LoginPage()
        {
            
        }

        public void NavigateURL(string uRL)
        {
            driver.Navigate().GoToUrl(uRL);
            driver.Manage().Window.Maximize();
        } 
        public void LoadData(string username, string passowrd)
        {
            driver.FindElement(By.XPath("//*[@type='text']")).SendKeys(username);
            driver.FindElement(By.XPath("//*[@id='password']")).SendKeys(passowrd);
        } 
        public void ClickLoginButton()
        {
            driver.FindElement(By.XPath("//*[@type='submit']")).Click();
        }
        public void CheckDashboard()
        {
            string Mytitle = driver.Title;
            Assert.AreEqual("ReligiO", Mytitle);
        }
        






    }


}
