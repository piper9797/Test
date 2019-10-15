using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace test_for_horse_web_piper
{
    internal class TimeMaterialCreatePage
    {
        private IWebDriver driver;

        public TimeMaterialCreatePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void createNew()
        {
            driver.FindElement(By.XPath("//a[@href='/TimeMaterial/Create']")).Click();
        }


        public void validateRecord()
        {
            Thread.Sleep(2000);
            try
            {
                while (true)
                {
                    for (int i = 1; i <= 10; i++)


                    {

                        IWebElement record = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[1]"));


                        if (record.Text == "6666")
                        {
                            Console.WriteLine("success" + record.Text);
                            Assert.That(record.Text, Is.EqualTo("6666"));
                            return;
                        }
                    }

                    driver.FindElement(By.XPath("//span[contains(.,'Go to the next page')]")).Click();
                }
            }

            catch (Exception)
            {

                Console.WriteLine("fail");

            }
        }

    }
}