using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Utilities
{
    class Async
    {

        public static void WaitForElement(IWebDriver driver, String locator, String domValue, int second)
        {
            try
            {
                // visible
                if (locator == "Xpath")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, second));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(domValue)));
                }

                // clickable
                if (locator == "Id")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, second));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(domValue)));
                }
            }
            catch (Exception msg)
            {
                Assert.Fail(msg.Message);

            }
        }
    }
}
