using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.ComponentModel;
using TechTalk.SpecFlow;
using BoDi;

namespace SpecFlowDemo.Hooks
{
    [Binding]
    public sealed class DemoHooks
    {

        private readonly IObjectContainer container;
        public DemoHooks(IObjectContainer container)
        {
            this.container = container;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        { 
        
        }
        [BeforeFeature]
        public static void BeforeFeature() { 
        
        }
        [BeforeScenario]
        public void BeforeScenario() 
        {
            // the IWebDriver interface
            ChromeDriver driver = new ChromeDriver();
            //ChromeDriver driver = new ChromeDriver();


            // Make 'driver' available for DI (Dependency injection)
            container.RegisterInstanceAs<IWebDriver>(driver);


        }
        [BeforeStep]
        public void BeforeStep() { 
        
        }

        [AfterStep]
        public void AfterScenario()
        {
            IWebDriver driver = container.Resolve<IWebDriver>();
            try
            {
                //driver.Close();
                //driver.Dispose();
            }
            catch (Exception e)
            {
                e.GetBaseException();
            }
        }
        [AfterScenario]
        public void AfterStep() {
        
        }
        [AfterFeature]
        public static void AfterFeature() { 
        
        }
        [AfterTestRun]
        public static void AfterTestRun() { 
        
        }



    }
}