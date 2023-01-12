using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.ComponentModel;
using TechTalk.SpecFlow;
using BoDi;

namespace SpecFlowDemo.Hooks
{
    [Binding]
    public sealed class SpecFlowDemoHooks
    {

        private readonly IObjectContainer container;
        public SpecFlowDemoHooks(IObjectContainer container)
        {
            this.container = container;
        }

        
        public static void BeforeTestRun()
        { 
        
        }
       
        public static void BeforeFeature() { 
        
        }
       
        public void BeforeScenario() 
        {
            // the IWebDriver interface
            ChromeDriver driver = new ChromeDriver();
            //ChromeDriver driver = new ChromeDriver();


            // Make 'driver' available for DI (Dependency injection)
            container.RegisterInstanceAs<IWebDriver>(driver);


        } 
        public void BeforeStep() { 
        
        } 
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
        public void AfterStep() {
        
        } 
        public static void AfterFeature() { 
        
        } 
        public static void AfterTestRun() { 
        
        }



    }
}