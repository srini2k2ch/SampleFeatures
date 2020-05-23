using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SampleFeatures
{
    class SampleClass1
    {
        public void Sample()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.youtube.com");
            driver.FindElement(By.Name("search_query")).SendKeys("c# automation");
            Thread.Sleep(3000);
            driver.Quit();

        }
    }
}
