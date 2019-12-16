using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;

using System;
using System.Threading;

namespace First_Test

{

    class Entrypoint
    {

        static void Main()
        {

            IWebDriver driver = new ChromeDriver("./");

            //NuGet package which will copy the driver to the bin folder.
            //Then you can provide path to the current folder to driver ctor to run your tests:


            driver.Navigate().GoToUrl("http://116.203.214.214/");


            
            IWebElement Userid = driver.FindElement(By.Name("email"));
            Userid.Click();
            Userid.SendKeys("test@abc.com");
            Thread.Sleep(3000);

            IWebElement password = driver.FindElement(By.Name("password"));
            password.Click();
            password.SendKeys("abc");
            Thread.Sleep(3000);



           IWebElement Button = driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[5]/button"));
           Button.Click();


            // IWebelement element = driver.FindElement(By.xpath("xpath of Webelement"));

            // Boolean status = element.Enabled;
            Thread.Sleep(3000);
            driver.Close();
            driver.Quit();

        }

    }
}
