using Dynamitey.DynamicObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;

namespace SpecFlowDemo.Pages
{
    public class BasePageObject
    {
        protected readonly IWebDriver _webDriver;
        protected readonly IWait<IWebDriver> _wait;

        protected readonly int iWebDriverType = 1; // 1 - IWebDriver and  2 

        protected BasePageObject(IWebDriver webDriver)
        {
            PageFactory.InitElements(webDriver, this);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(5000);
            _wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(1000));
            _webDriver = webDriver;
        }
        public void OpenWebDriver(string url)
        {
            _webDriver.Navigate().GoToUrl(url);
            _webDriver.Manage().Window.Maximize();
        }
         
    }
}
