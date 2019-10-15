using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Test.Utilities;

namespace test_for_horse_web_piper
{
    internal class TimeMaterialPage
    {
        private IWebDriver driver;

        public TimeMaterialPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void fill_in(IWebDriver driver)
        {
            // choose time
            /* driver.FindElement(By.XPath("(//span[@unselectable='on'][contains(.,'select')])[4]")).Click();
             driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);*/



            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();
            Async.WaitForElement(driver, "Xpath", "//*[@id='TypeCode_listbox']/li[2]", 3);
          //  Thread.Sleep(200);
            driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]")).Click();
            Thread.Sleep(200);

            // code
            driver.FindElement(By.XPath("//input[@id='Code']")).SendKeys("6666");
            //description
            driver.FindElement(By.XPath("//input[contains(@id,'Description')]")).SendKeys("test by Piper");
            //price
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driver.FindElement(By.XPath("//input[@class='k-formatted-value k-input']")).SendKeys("66");
        }

        internal void save()
        {
            driver.FindElement(By.XPath("//input[contains(@id,'SaveButton')]")).Click();
        }


        internal void Edit()
        {
           // Thread.Sleep(2000);
            Async.WaitForElement(driver, "Xpath", "(//a[contains(@class,'k-button k-button-icontext k-grid-Edit')])[6]", 3);
            
            IWebElement editbtn = driver.FindElement(By.XPath("(//a[contains(@class,'k-button k-button-icontext k-grid-Edit')])[6]"));
            editbtn.Click();
            IWebElement code1 = driver.FindElement(By.XPath("//input[@id='Code']"));
            code1.Clear();
            code1.SendKeys("9999");
            IWebElement savebtm1 = driver.FindElement(By.Id("SaveButton"));
            savebtm1.Click();

        }


        internal void Delete()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            IWebElement deletebtm1 = driver.FindElement(By.XPath("(//a[@class='k-button k-button-icontext k-grid-Delete'][contains(.,'Delete')])[1]"));
            deletebtm1.Click();
            driver.SwitchTo().Alert().Accept();

        }



        internal void ChangeNumberOfRowDisplayingOnEachPage()
        {
            driver.FindElement(By.XPath("//span[contains(@class,'k-icon k-i-arrow-s')]")).Click();

            IWebElement options = driver.FindElement(By.XPath("//li[@tabindex='-1'][contains(.,'20')]"));
            options.Click();

        }

    }
}