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
        /// <summary>
        /// This method used to get the id from the active page and bind the value is passed and then action to be performed
        /// </summary>
        /// <param name="XPath"></param>
        /// <param name="Value"></param>
        /// <param name="Action"></param>
        public void FindElementByXPath(string XPath)
        {
            FindElementByXPath(XPath, "", "");
        }

        /// <summary>
        /// This method used to get the id from the active page and bind the value is passed and then action to be performed
        /// </summary>
        /// <param name="XPath"></param>
        /// <param name="Value"></param>
        /// <param name="Action"></param>
        public void FindElementByXPath(string XPath, string Value)
        {
            FindElementByXPath(XPath, Value, "SendKeys");
        }

        /// <summary>
        /// This method used to get the id from the active page and bind the value is passed and then action to be performed
        /// </summary>
        /// <param name="XPath"></param>
        /// <param name="Value"></param>
        /// <param name="Action"></param>
        public void FindElementByXPath(string XPath, string Value, string Action)
        {
            if (Action == "SendKeys")
            {
                _webDriver.FindElement(By.XPath(XPath)).SendKeys(Value);
            } 
            else if (Action == "Clear")
            {
                _webDriver.FindElement(By.XPath(XPath)).Clear();
            }
            else
            {
                _webDriver.FindElement(By.XPath(XPath)).Click();
            }

        }


    }
}
